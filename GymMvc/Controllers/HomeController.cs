using GymMvc.Model_View;
using GymMvc.Data;
using GymMvc.Models;
using GymMvc.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Cryptography;
using Azure.Core;

namespace GymMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInformationService _InformServices;
        private readonly IUserServies _User;
        private readonly ApplicationDbContext _Context;
        public HomeController(IUserServies user, ApplicationDbContext context, IInformationService inform)
        {
            _User = user;
            _Context = context;
            _InformServices = inform;
        }
        public async Task< IActionResult> Index(LoginView model)
        {
            if (!ModelState.IsValid)
            {
                model.Users = _User.GetUser();
                return View(model);

            }
            var user =await _Context.Logins
                .FirstOrDefaultAsync(u => u.User_Name==model.User_Name);
               
            if (user == null )
            {
                return BadRequest("User Not Found.");
            }
            if (!VerifyPasswordHash(model.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Password is incorrect.");
            }
            if (user?.UserId != model.UserId)
            {
                return BadRequest("User Is Wrong.");
            }
            else
            {
                
                if (user.UserId == 1)
                {
                    return Redirect($"~/Users/Coache/{user.InformationId}");
                }
                if (user.UserId == 2)
                {
                    return Redirect($"~/Users/Trainer/{user.InformationId}");
                }
                else
                {
                    return Redirect($"~/Users/Admin/{user.InformationId}");
                }
            }
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            RequestView viewModel = new()
            {
                Users = _User.GetUser(),
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUser(RequestView model)
        {

            if (!ModelState.IsValid)
            {
                model.Users = _User.GetUser();
                return View(model);

            }
            if (_Context.Logins.Any(u => u.User_Name == model.User_Name))
            {
                return BadRequest("User already exists.");
            }
            CreatePasswordHash(model.Password, out byte[] passwordHash, out byte[] passwordSalt);
            _InformServices.CreateUser(model,passwordHash,passwordSalt);
            return Redirect("~/Home/Index");
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Test()
        {
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
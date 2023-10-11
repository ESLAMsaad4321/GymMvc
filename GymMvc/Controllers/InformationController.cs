using GymMvc.Model_View;
using GymMvc.Data;
using GymMvc.Models;
using GymMvc.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GymMvc.Controllers
{
    public class InformationController : Controller
    {
        private readonly IInformationService _InformServices;
        private readonly IUserServies _User;

        public InformationController(IInformationService informServices,IUserServies user)
        {
            _InformServices = informServices;
            _User = user;
        }
       
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = _InformServices.GetInfor(id);
            if (user == null)
                return NotFound();
            EditFormViewModel ViewModel = new EditFormViewModel
            {
                Name = user.Name,
                Age = user.Age,
                Phone_Number = user.Phone_Number,
                Description = user.Description,
                Height = user.Height,
                Weight = user.Weight,
                years_of_experience = user.years_of_experience,
                Specialty = user.Specialty,
                Email = user.Email,
                UserId = user.UserId,
                CurrentImage = user.Image,
            };
            return View(ViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditFormViewModel model)
        {

            if (!ModelState.IsValid)
            {
                model.Users = _User.GetUser();
                return View(model);

            }
            var user = _InformServices.Update(model);
            if (user == null)
                return BadRequest();
            return Redirect("~/Home/Index");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var isdeleted = _InformServices.Delete(id);
            if (isdeleted)
                return Redirect("~/Home/Index");
            return BadRequest();
        }
    }
}

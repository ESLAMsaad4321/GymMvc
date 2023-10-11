using GymMvc.Data;
using GymMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace GymMvc.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IInformationService _InformServices;
        public UsersController(ApplicationDbContext context, IInformationService InformServices)
        {
            _InformServices = InformServices;
            _context = context;
        }
        public IActionResult Trainer(int id)
        {
            var user = _InformServices.GetInfor(id);
            if (user is null)
                return NotFound();
            return View(user);
        }

        public IActionResult Admin(int id)
        {
            var user = _InformServices.GetInfor(id);
            if (user is null)
                return NotFound();
            return View(user);
        }
        public IActionResult AllCoache()
        {
            var users = _InformServices.GetAllCoache();
            return View(users);
        }
        public IActionResult AllCoachewithReq(int id)
        {

            _InformServices.sent(id);
            var users = _InformServices.GetAllCoache();
            return View(users);
        }
        public IActionResult Coache(int id)
        {
            var user = _InformServices.GetInfor(id);
            if (user is null)
                return null!;
            return View(user);
        }
        public IActionResult AllTrainer()
        {
            var users = _InformServices.GetAllTrainer();
            return View(users);
        }
        public IActionResult TheCoacheTrainer(int id)
        {
            var users = _InformServices.GetTheCoacheTrainer(id);
            if (users is null)
                return View();
            return View(users);
        }

    }
}

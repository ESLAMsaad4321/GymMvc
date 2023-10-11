using GymMvc.Models;
using GymMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace GymMvc.Controllers
{
    public class WeightController : Controller
    {
        private readonly IInformationService _InformServices;
        private readonly IWorkOutServices _WorkOut;

        private readonly IUserServies _User;

        public WeightController(IInformationService informServices, IWorkOutServices workOut, IUserServies user)
        {
            _InformServices = informServices;
            _User = user;
            _WorkOut = workOut;
        }
        [HttpGet]
        public IActionResult UpdateWeight()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateWeight(int id, UpdateWeight model)
        {
            _InformServices.UpdateWeight(id, model);
            return Test();
        }
        public IActionResult Weights(int id)
        {
            var weights = _InformServices.Weights(id);
            return View(weights);
        }
        public IActionResult Test()
        {
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}

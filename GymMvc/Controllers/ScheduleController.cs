using GymMvc.Model_View;
using GymMvc.Models;
using GymMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace GymMvc.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly IInformationService _InformServices;
        private readonly IWorkOutServices _WorkOut;

        private readonly IUserServies _User;

        public ScheduleController(IInformationService informServices, IWorkOutServices workOut, IUserServies user)
        {
            _InformServices = informServices;
            _User = user;
            _WorkOut = workOut;
        }
        public IActionResult Schedule(int id)
        {
            var schedule = _InformServices.Schedule(id);
            if (schedule is null)
                return View();
            return View(schedule);
        }
        [HttpGet]
        public IActionResult CreateSchedule()
        {
            CreateSchedule schedule1 = new()
            {
                WorkOuts = _WorkOut.GetWorkOut()
            };
            return View(schedule1);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateSchedule(int id, CreateSchedule schedule)
        {
            if (!ModelState.IsValid)
            {
                schedule.WorkOuts = _WorkOut.GetWorkOut();
                return View(schedule);

            }
            _InformServices.CreateSchedule(id, schedule);
            return Test();
        }
        public IActionResult Test()
        {
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}

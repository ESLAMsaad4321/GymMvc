using GymMvc.Data;
using GymMvc.Models;
using GymMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace GymMvc.Controllers
{
    public class RequestController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IInformationService _InformServices;

        public RequestController(ApplicationDbContext context, IInformationService InformServices)
        {
            _InformServices = InformServices;
            _context = context;
        }
        public new IActionResult Request(int id)
        {
            var user = _context.Information.Find(id);
            if (user is null)
                return BadRequest();
            var notification = new Notification
            {
                Sent = _InformServices.save(),
                Receive = id
            };
            _context.Notifications.Add(notification);
            var effect = _context.SaveChanges();
            if (effect > 0)
            {
                return Redirect("~/Home/Index");
            }
            return BadRequest();

        }
        public IActionResult ApproveRequest(int id)
        {
            var result = _context.Notifications.FirstOrDefault(n => n.Sent == id&&n.Receive==_InformServices.Receive());

            if (result is null)
                return null!;
            result.Approve = true;
            var effect = _context.SaveChanges();
            if (effect > 0)
            {
                return Redirect("~/Home/Index");
            }
            return BadRequest();
        }
        public IActionResult RejectRequest(int id)
        {
            var result = _context.Notifications.FirstOrDefault(n => n.Sent == id);

            if (result is null)
                return null!;
            result.Approve = false;
            var effect = _context.SaveChanges();
            if (effect > 0)
            {
                return Redirect("~/Home/Index");
            }
            return BadRequest();
        }
        public IActionResult Notification(int id)
        {
            var users = _InformServices.GetRequestedTranier(id);
            if (users is null)
                return null!;
            return View(users);
        }
    }
}

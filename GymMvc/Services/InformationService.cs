using GymMvc.Data;
using GymMvc.Model_View;
using GymMvc.Models;
using GymMvc.Setting;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace GymMvc.Services
{
    public class InformationService : IInformationService
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _imagepath;
        private static int num=0;
        private static int num1=0;

        public InformationService(IWebHostEnvironment webHostEnvironment, ApplicationDbContext context)
        {
            _webHostEnvironment = webHostEnvironment;
            _context = context;
            _imagepath = $"{_webHostEnvironment.WebRootPath}{FileSetting.imagepath}";
        }

        public void CreateUser(RequestView model, byte[] passwordHash, byte[] passwordSalt)
        {
            var imagename = SaveImage(model.Image);
            var user = new Login
            {
                User_Name = model.User_Name,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                UserId = model.UserId,
                Information = new Information
                {

                    Name = model.Name,
                    Age = model.Age,
                    Phone_Number = model.Phone_Number,
                    Image = imagename,
                    Description = model.Description,
                    Height = model.Height,
                    Weight = model.Weight,
                    years_of_experience = model.years_of_experience,
                    Specialty = model.Specialty,
                    Email = model.Email,
                    UserId = model.UserId

                }
            };


            _context.Logins.Add(user);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            var Isdeleted = false;
            var user = _context.Information.Find(id);
            if (user is null)
                return Isdeleted;
            _context.Information.Remove(user);
            var effect = _context.SaveChanges();
            if (effect>0)
            {
                Isdeleted=true;
                var image = Path.Combine(_imagepath, user.Image);
                File.Delete(image);
            }
            return Isdeleted;
        }


        public IEnumerable<Information> GetAllCoache()
        {
            return _context.Information
                .Where(i=>i.UserId==1)
                .ToList();
        }

        public IEnumerable<Information> GetAllTrainer()
        {
            return _context.Information
                            .Where(i => i.UserId == 2)
                            .ToList();
        }
        public IEnumerable<Notification> GetRequestedTranier(int id)
        {
            num1 = id;
            var result = _context.Notifications
                            .Include(n => n.Trainer)
                            .Where(n => n.Receive == id && n.Approve == null && n.Sent == n.Trainer.Id);
            if (result == null)
                return null!;
            return result;
        }
        public IEnumerable<Notification> GetTheCoacheTrainer(int id)
        {
            num1 = id;
            var result =_context.Notifications
                .Include(n=>n.Trainer)
                .Where(n=>n.Receive==id && n.Approve == true&&n.Sent==n.Trainer.Id);
            if (result == null)
                return null!;
            return result; 
        }

        public Information? GetInfor(int id)
        {
           
            
            return _context.Information
                .SingleOrDefault(i => i.Id == id);
             
        }
        public List<Information?> GetInforandcoache(int id)
        {
            var result = _context.Information
                .Where(i => i.Id == id).Where(i => i.UserId == 1).ToList();
            return result;


        }


        public Task<Information?> Update(EditFormViewModel model)
        {
            var user = _context.Information.Find(model.Id);
            if (user == null)
                return Task.FromResult<Information?>(null);
            user.Name = model.Name;
            user.Age = model.Age;
            user.Phone_Number = model.Phone_Number;
            user.Description = model.Description;
            user.Height = model.Height;
            user.Weight = model.Weight;
            user.years_of_experience = model.years_of_experience;
            user.Specialty = model.Specialty;
            user.Email = model.Email;
            var OldImage = user.Image;
            var Ishaveimage = model.Image is not null; 
            if (Ishaveimage)
            {
                user.Image=SaveImage(model.Image!);
            }
            var effect = _context.SaveChanges();
            if (effect >0)
            {
                if (Ishaveimage )
                {
                    var image = Path.Combine(_imagepath, OldImage);
                    File.Delete(image);
                }
                return Task.FromResult<Information?>(user);
            }
            else
            {
                var image = Path.Combine(_imagepath, user.Image);
                File.Delete(image);
                return Task.FromResult<Information?>(null);
            }

        }

        private string SaveImage (IFormFile Image)
        {
            var imagename = $"{Guid.NewGuid()}{Path.GetExtension(Image.FileName)}";
            var path = Path.Combine(_imagepath, imagename);
            using var stream = File.Create(path);
             Image.CopyToAsync(stream);
            return imagename ;
        }
   

        public int sent(int id)
        {
            var sent = id;
            num = id;
            return sent;

        }
        public int Receive ()
        {
            var Receive=num1 ; return Receive;
        }
        public int save ()
        {
            var sent = num;
            return sent;
        }
        public IEnumerable <ScheduleWorkOut?> Schedule (int id)
        {
            var schedule = _context.ScheduleWorkOuts
                .Include(s=>s.Schedule)
                .Include(s=>s.WorkOut)
                .AsNoTracking()
                .Where(s=>s.Schedule.TrainerId==id);
            if (schedule == null)
                return null!;
            return schedule;
        }


        public void CreateSchedule(int id, CreateSchedule schedule)
        {
            Schedule schedule1 = new()
            {
                TrainerId=id,
                CoacheId=num1,
                WorkOuts= schedule.SelectWorkOut.Select(d => new ScheduleWorkOut { WorkOutId = d,Day=schedule.Day  }).ToList()
            };
            _context.Schedules.Add(schedule1);
            _context.SaveChanges();
        }
        public void UpdateWeight(int id , UpdateWeight model)
        {
            var oldweight = _context.Information.FirstOrDefault(i=>i.Id==id);
            UpdateWeight model1 = new()
            {

                TrainerId = id,
                OldWeight = oldweight?.Weight,
                NewWeight =model.NewWeight,
                dateTime = DateTime.Now,
            };
            _context.UpdateWeights.Add(model1);
            _context.SaveChanges();
            oldweight!.Weight = model.NewWeight;
            _context.Information.Update(oldweight);
            _context.SaveChanges();
        }
        public IEnumerable<UpdateWeight> Weights(int id)
        {
            var Weight = _context.UpdateWeights
                .AsNoTracking()
                .Where(s => s.TrainerId == id);
            if (Weight == null)
                return null!;
            return Weight;
        }
    }
}

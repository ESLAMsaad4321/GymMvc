using GymMvc.Model_View;
using GymMvc.Models;
using Microsoft.AspNetCore.Identity;

namespace GymMvc.Services
{
    public interface IInformationService
    {
        IEnumerable<Information> GetAllCoache();
        IEnumerable<Information> GetAllTrainer();
        IEnumerable<ScheduleWorkOut?> Schedule(int id);
        IEnumerable<Notification> GetRequestedTranier(int id);
        IEnumerable<Notification> GetTheCoacheTrainer(int id);

        IEnumerable<UpdateWeight> Weights(int id);
        void CreateSchedule(int id,CreateSchedule schedule);
        Information? GetInfor (int id);
        List <Information?> GetInforandcoache (int id);
         void CreateUser(RequestView model,byte[] passwordHash,byte[] passwordSalt);
        void UpdateWeight(int id,UpdateWeight model);
        Task<Information?> Update(EditFormViewModel model);
         bool Delete (int id);
        int sent (int id);
        int save ();
        int Receive();
    }
}

namespace GymMvc.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int CoacheId { get; set; }
        public int TrainerId { get; set; }
        public ICollection<ScheduleWorkOut> WorkOuts { get; set; } = new List<ScheduleWorkOut>();

    }
}

namespace GymMvc.Models
{
    public class ScheduleWorkOut
    {
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; } = default!;
        public int WorkOutId { get; set; }
        public WorkOut WorkOut { get; set; } = default!;
        public int Day { get; set; }
    }
}

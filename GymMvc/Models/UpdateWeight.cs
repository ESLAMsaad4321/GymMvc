namespace GymMvc.Models
{
    public class UpdateWeight
    {
        public int Id { get; set; }
        public int TrainerId { get; set; }
        public decimal? OldWeight { get; set; }
        public decimal NewWeight { get; set; }
        public DateTime dateTime { get; set; }
    }
}

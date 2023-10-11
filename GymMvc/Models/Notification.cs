namespace GymMvc.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int? Sent { get; set; }
        public Information Trainer { get; set; } = default!;

        public int? Receive { get; set; }
        public bool? Approve { get; set; }
    }
}

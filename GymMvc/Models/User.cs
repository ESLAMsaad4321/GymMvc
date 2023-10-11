namespace GymMvc.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }= String.Empty;
        public ICollection<Information> information { get; set; } = new List<Information>();
    }
}

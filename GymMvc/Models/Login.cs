using System.ComponentModel.DataAnnotations;

namespace GymMvc.Models
{
    public class Login
    {
        public string User_Name { get; set; } = null!;
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = default!;
        public byte[]? PasswordHash { get; set; }

        public byte[]? PasswordSalt { get; set; }
        public int InformationId { get; set; }
        public Information? Information { get; set; }


    }
}

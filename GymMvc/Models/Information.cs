using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymMvc.Models
{
    public class Information
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty; 
        public decimal Age { get; set; }
        [Column("Phone Number")]
        public string Phone_Number { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Image { get; set; } = string.Empty;
        [MaxLength(500)]
        public string? Description { get; set; } = string.Empty;
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public int? years_of_experience { get; set; }
        public string? Specialty { get; set; } 
        public string? Email { get; set; } 
        public int UserId { get; set; }
        public User User { get; set; } = default!;
        public Login Login { get; set; } = default!;
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    }
}

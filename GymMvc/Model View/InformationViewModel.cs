using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GymMvc.Model_View
{
    public class InformationViewModel
    {

        [Required]
        
        [Display(Name = "User")]
        public int UserId { get; set; }
        public IEnumerable<SelectListItem> Users { get; set; } = Enumerable.Empty<SelectListItem>();
        public string Name { get; set; } = string.Empty;
        public decimal Age { get; set; }
        public string Phone_Number { get; set; } = string.Empty;
        [MaxLength(500)]
        public string? Description { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public int? years_of_experience { get; set; }
        public string? Specialty { get; set; }
        public string? Email { get; set; } = string.Empty;
    }
}

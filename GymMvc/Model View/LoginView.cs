using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GymMvc.Model_View
{
    public class LoginView
    {

        [Display (Name ="User Name")]
        public string User_Name { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Display(Name = "User")]
        public int UserId { get; set; }
        public IEnumerable<SelectListItem> Users { get; set; } = Enumerable.Empty<SelectListItem>();
    }
}

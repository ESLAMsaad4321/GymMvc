using GymMvc.Setting;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymMvc.Model_View
{
    public class RequestView:InformationViewModel
    {
        [Display(Name = "User Name")]
        public string User_Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
        public IFormFile Image { get; set; } = default!;

    }
}

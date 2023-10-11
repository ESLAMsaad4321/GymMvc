using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GymMvc.Model_View
{
    public class CreateSchedule
    {
        public int Day { get; set; }
        [Display(Name = "WorkOut")]
        public List<int> SelectWorkOut { get; set; } = default!;
        public IEnumerable<SelectListItem> WorkOuts { get; set; } = Enumerable.Empty<SelectListItem>();
    }
}

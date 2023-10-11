using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymMvc.Services
{
    public interface IUserServies
    {

        IEnumerable<SelectListItem> GetUser();
    }
}

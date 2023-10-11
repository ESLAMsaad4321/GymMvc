using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymMvc.Services
{
    public interface IWorkOutServices
    {
        IEnumerable<SelectListItem> GetWorkOut();

    }
}

using GymMvc.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Entity;

namespace GymMvc.Services
{
    
    public class WorkOutServices : IWorkOutServices
    {
        private readonly ApplicationDbContext _Context;

        public WorkOutServices(ApplicationDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<SelectListItem> GetWorkOut()
        {
            return _Context.WorkOuts
                            .Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name })
                            .OrderBy(d => d.Text)
                            .AsNoTracking()
                            .ToList();
        }
    }
}

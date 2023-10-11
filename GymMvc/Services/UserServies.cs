using GymMvc.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Entity;

namespace GymMvc.Services;

public class UserServies : IUserServies
    {
        private readonly ApplicationDbContext _Context;
        public UserServies(ApplicationDbContext context)
        {
            _Context = context;
        }

    public IEnumerable<SelectListItem> GetUser()
    {
        return _Context.Users
              .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
              .OrderBy(c => c.Text)
              .AsNoTracking()
              .ToList();
    }
}


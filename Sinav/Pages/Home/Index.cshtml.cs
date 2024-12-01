using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sinav.Domain;
using Sinav.Infrastructure;

namespace Sinav.Pages.Home
{
    public class IndexModel : PageModel
    {
        public readonly IConfiguration _configuration;
        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

   
        public void OnGet()
        {
            using (var context = new SinavDbContext(_configuration))
            {
                context.Database.EnsureCreated();
                User2 user = new User2();
                user.Name = "Ahmet";
                user.Email = "asdasdaq@asdas.com";
                user.Password = "asdsadsada";
                context.User.Add(user);
                context.SaveChanges();
            }
        }
    }
}

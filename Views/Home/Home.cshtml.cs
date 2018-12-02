using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSCI_3600_Group_Project.Views.Home
{
    public class HomeModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public HomeModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

/*        public async Task<IActionResult> OnGetAsync()
        {
             
        }*/
    }
}
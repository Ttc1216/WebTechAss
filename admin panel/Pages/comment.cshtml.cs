using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace admin_panel.Pages
{
    [Authorize]
    public class commentModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

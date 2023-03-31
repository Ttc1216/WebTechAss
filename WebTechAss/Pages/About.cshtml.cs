using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebTechAss.Pages
{
    public class AboutModel : PageModel
    {
        public string Name { get; set; }
        public void OnGet()
        {
            Name = "Hello This is About Page";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebTech.Shared.Models;

namespace WebTechAss.Pages.Resources
{
    public class DetailsModel : PageModel
    {
        private readonly WebTech.Shared.Models.autismDBContext _context;

        public DetailsModel(WebTech.Shared.Models.autismDBContext context)
        {
            _context = context;
        }

      public Resource Resource { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Resource == null)
            {
                return NotFound();
            }

            var resource = await _context.Resource.FirstOrDefaultAsync(m => m.Id == id);
            if (resource == null)
            {
                return NotFound();
            }
            else 
            {
                Resource = resource;
            }
            return Page();
        }
    }
}

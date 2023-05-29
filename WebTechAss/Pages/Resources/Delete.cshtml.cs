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
    public class DeleteModel : PageModel
    {
        private readonly WebTech.Shared.Models.autismDBContext _context;

        public DeleteModel(WebTech.Shared.Models.autismDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Resource == null)
            {
                return NotFound();
            }
            var resource = await _context.Resource.FindAsync(id);

            if (resource != null)
            {
                Resource = resource;
                _context.Resource.Remove(Resource);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

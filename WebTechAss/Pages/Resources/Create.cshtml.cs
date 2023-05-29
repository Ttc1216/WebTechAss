using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebTech.Shared.Models;

namespace WebTechAss.Pages.Resources
{
    public class CreateModel : PageModel
    {
        private readonly WebTech.Shared.Models.autismDBContext _context;

        public CreateModel(WebTech.Shared.Models.autismDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ResourceAgeRangeId"] = new SelectList(_context.ResourceAgeRange, "Id", "Name");
        ViewData["ResourceCategoryId"] = new SelectList(_context.ResourceCategory, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Resource Resource { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Resource == null || Resource == null)
            {
                return Page();
            }

            _context.Resource.Add(Resource);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

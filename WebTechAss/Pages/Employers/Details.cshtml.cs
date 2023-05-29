using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebTech.Shared.Models;

namespace WebTechAss.Pages.Employers
{
    public class DetailsModel : PageModel
    {
        private readonly WebTech.Shared.Models.autismDBContext _context;

        public DetailsModel(WebTech.Shared.Models.autismDBContext context)
        {
            _context = context;
        }

      public Employer Employer { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Employer == null)
            {
                return NotFound();
            }

            var employer = await _context.Employer.FirstOrDefaultAsync(m => m.Id == id);
            if (employer == null)
            {
                return NotFound();
            }
            else 
            {
                Employer = employer;
            }
            return Page();
        }
    }
}

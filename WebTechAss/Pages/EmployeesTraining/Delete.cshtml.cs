using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebTech.Shared.Models;

namespace WebTechAss.Pages.EmployeesTraining
{
    public class DeleteModel : PageModel
    {
        private readonly WebTech.Shared.Models.autismDBContext _context;

        public DeleteModel(WebTech.Shared.Models.autismDBContext context)
        {
            _context = context;
        }

        [BindProperty]
      public EmploymentTraining EmploymentTraining { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.EmploymentTraining == null)
            {
                return NotFound();
            }

            var employmenttraining = await _context.EmploymentTraining.FirstOrDefaultAsync(m => m.Id == id);

            if (employmenttraining == null)
            {
                return NotFound();
            }
            else 
            {
                EmploymentTraining = employmenttraining;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.EmploymentTraining == null)
            {
                return NotFound();
            }
            var employmenttraining = await _context.EmploymentTraining.FindAsync(id);

            if (employmenttraining != null)
            {
                EmploymentTraining = employmenttraining;
                _context.EmploymentTraining.Remove(EmploymentTraining);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebTech.Shared.Models;

namespace WebTechAss.Pages.EmployeesTraining
{
    public class EditModel : PageModel
    {
        private readonly WebTech.Shared.Models.autismDBContext _context;

        public EditModel(WebTech.Shared.Models.autismDBContext context)
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

            var employmenttraining =  await _context.EmploymentTraining.FirstOrDefaultAsync(m => m.Id == id);
            if (employmenttraining == null)
            {
                return NotFound();
            }
            EmploymentTraining = employmenttraining;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EmploymentTraining).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmploymentTrainingExists(EmploymentTraining.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmploymentTrainingExists(int id)
        {
          return (_context.EmploymentTraining?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

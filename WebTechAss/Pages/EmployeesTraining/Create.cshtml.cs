using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebTech.Shared.Models;

namespace WebTechAss.Pages.EmployeesTraining
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
            return Page();
        }

        [BindProperty]
        public EmploymentTraining EmploymentTraining { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.EmploymentTraining == null || EmploymentTraining == null)
            {
                return Page();
            }

            _context.EmploymentTraining.Add(EmploymentTraining);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

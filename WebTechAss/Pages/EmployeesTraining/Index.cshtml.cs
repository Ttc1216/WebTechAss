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
    public class IndexModel : PageModel
    {
        private readonly WebTech.Shared.Models.autismDBContext _context;

        public IndexModel(WebTech.Shared.Models.autismDBContext context)
        {
            _context = context;
        }

        public IList<EmploymentTraining> EmploymentTraining { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.EmploymentTraining != null)
            {
                EmploymentTraining = await _context.EmploymentTraining.ToListAsync();
            }
        }
    }
}

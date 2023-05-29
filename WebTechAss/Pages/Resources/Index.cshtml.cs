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
    public class IndexModel : PageModel
    {
        private readonly WebTech.Shared.Models.autismDBContext _context;

        public IndexModel(WebTech.Shared.Models.autismDBContext context)
        {
            _context = context;
        }

        public IList<Resource> Resource { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Resource != null)
            {
                Resource = await _context.Resource
                .Include(r => r.ResourceAgeRange)
                .Include(r => r.ResourceCategory).ToListAsync();
            }
        }
    }
}

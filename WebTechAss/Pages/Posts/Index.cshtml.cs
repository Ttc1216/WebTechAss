using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebTech.Shared.Models;

namespace WebTechAss.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly WebTech.Shared.Models.autismDBContext _context;

        public IndexModel(WebTech.Shared.Models.autismDBContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Post != null)
            {
                Post = await _context.Post
                .Include(p => p.Author)
                .Include(p => p.Parent).ToListAsync();
            }
        }
    }
}

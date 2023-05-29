using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebTech.Shared.Models;

namespace WebTechAss.Pages.Posts
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
        ViewData["AuthorId"] = new SelectList(_context.User, "Id", "PasswordHash");
        ViewData["ParentId"] = new SelectList(_context.Post, "Id", "Slug");
            return Page();
        }

        [BindProperty]
        public Post Post { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Post == null || Post == null)
            {
                return Page();
            }

            _context.Post.Add(Post);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebTech.Shared.Models;

namespace WebTechAss.Pages.Posts
{
    public class EditModel : PageModel
    {
        private readonly WebTech.Shared.Models.autismDBContext _context;

        public EditModel(WebTech.Shared.Models.autismDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Post Post { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Post == null)
            {
                return NotFound();
            }

            var post =  await _context.Post.FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            Post = post;
           ViewData["AuthorId"] = new SelectList(_context.User, "Id", "PasswordHash");
           ViewData["ParentId"] = new SelectList(_context.Post, "Id", "Slug");
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

            _context.Attach(Post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostExists(Post.Id))
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

        private bool PostExists(long id)
        {
          return (_context.Post?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

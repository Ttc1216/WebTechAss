﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebTech.Shared.Models;

namespace WebTechAss.Pages.Posts
{
    public class DetailsModel : PageModel
    {
        private readonly WebTech.Shared.Models.autismDBContext _context;

        public DetailsModel(WebTech.Shared.Models.autismDBContext context)
        {
            _context = context;
        }

      public Post Post { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.Post == null)
            {
                return NotFound();
            }

            var post = await _context.Post.FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            else 
            {
                Post = post;
            }
            return Page();
        }
    }
}

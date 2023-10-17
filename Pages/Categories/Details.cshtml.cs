using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_CommerceApp.Data;
using E_CommerceApp.Models;

namespace E_CommerceApp.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly E_CommerceApp.Data.ApplicationDbContext _context;

        public DetailsModel(E_CommerceApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Categorie Categorie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var categorie = await _context.Categories.FirstOrDefaultAsync(m => m.CategorieID == id);
            if (categorie == null)
            {
                return NotFound();
            }
            else 
            {
                Categorie = categorie;
            }
            return Page();
        }
    }
}

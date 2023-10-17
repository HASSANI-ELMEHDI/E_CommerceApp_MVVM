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
    public class IndexModel : PageModel
    {
        private readonly E_CommerceApp.Data.ApplicationDbContext _context;

        public IndexModel(E_CommerceApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Categorie> Categorie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Categories != null)
            {
                Categorie = await _context.Categories.ToListAsync();
            }
        }
    }
}

using E_CommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly E_CommerceApp.Data.ApplicationDbContext _context;

        public IndexModel(E_CommerceApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Produit> Produit { get; set; } = default!;

        public IList<Categorie> Categorie { get; set; } = default!;

        public async Task OnGetAsync(string searchString)
        {
            if (_context.Produits != null)
            {
                var produits = from p in _context.Produits
                    select p;

                if (!string.IsNullOrEmpty(searchString))
                {
                    produits = produits.Where(p => p.Description.Contains(searchString));
                    Produit = await produits.ToListAsync();
                }
                else Produit = await _context.Produits.Include(p => p.Categorie).ToListAsync();
            }
            if (_context.Categories != null)
            {
                Categorie = await _context.Categories.ToListAsync();
            }
        }
    }
}
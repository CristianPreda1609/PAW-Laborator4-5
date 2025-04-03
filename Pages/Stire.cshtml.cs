using Laborator4_5.ContextModels;
using Laborator4_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Laborator4_5.Pages
{
    public class StireModel : PageModel
    {
        private readonly StiriContext _stiriContext;

        public Stire Stire { get; set; }

        public StireModel(StiriContext stiriContext)
        {
            _stiriContext = stiriContext;
        }

        public IActionResult OnGet(int stireId)
        {
            Stire = _stiriContext.Stire
                .Include(s => s.Categorie)
                .FirstOrDefault(s => s.id == stireId);

            if (Stire == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

    }
}

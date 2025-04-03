using Laborator4_5.ContextModels;
using Laborator4_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Laborator4_5.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly StiriContext _stiriContext;

        public IndexModel(ILogger<IndexModel> logger, StiriContext stiriContext)
        {
            _logger = logger;
            _stiriContext = stiriContext;
        }

        public Stire[] Stiri { get; set; }

        public void OnGet()
        {
            Stiri = _stiriContext.Stire
                .Include(s => s.Categorie) 
                .ToArray();

        }
    }
}

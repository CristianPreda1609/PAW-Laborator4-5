using Laborator4_5.Models;
using Microsoft.EntityFrameworkCore;
namespace Laborator4_5.ContextModels
{


    public class StiriContext : DbContext
    {
        public StiriContext(DbContextOptions<StiriContext> options)
            : base(options) { }

        public DbSet<Stire> Stire { get; set; }
        public DbSet<Categorie> Categorie { get; set; }
    }
}

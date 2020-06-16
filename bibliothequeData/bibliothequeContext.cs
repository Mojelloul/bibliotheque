using bibliothequeData.Models;
using Microsoft.EntityFrameworkCore;

namespace bibliothequeData
{
    public class BibliothequeContext : DbContext

    {
        public BibliothequeContext (DbContextOptions options):base(options) { }
        public DbSet<Patron> Patrons { get; set; }
    }
}

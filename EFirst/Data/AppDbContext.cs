using Microsoft.EntityFrameworkCore;

namespace EFirst.Data
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options)
        {

        }

        public DbSet<Book> books { get; set; }

        public DbSet<Language> languages { get; set; }

        public DbSet<BookPrice> BookPrices { get; set; }    

        public DbSet<Currency> Currencies { get; set; }
        
    }
}

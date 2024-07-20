using Microsoft.EntityFrameworkCore;

namespace EFirst.Data
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options)
        {

        }
    }
}

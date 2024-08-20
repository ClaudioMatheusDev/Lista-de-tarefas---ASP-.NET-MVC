using Microsoft.EntityFrameworkCore;

namespace ListaDeTarefasASPNET.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }
}

using appweb1.models;
using Microsoft.EntityFrameworkCore;

namespace appweb1.data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options){}
        public DbSet<Cliente> Clientes { get; set; }
    }
}
using Api_Autentication.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Autentication.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}

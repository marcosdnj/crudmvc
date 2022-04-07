using crud.Models;
using Microsoft.EntityFrameworkCore;

namespace crud.Db
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuario { get; set; }

    }
}

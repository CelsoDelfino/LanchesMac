using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Data
{
    public class AppDbContext : DbContext
    {
        //carrega as informações de configuração necessárias para configurar o DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }

    }
}

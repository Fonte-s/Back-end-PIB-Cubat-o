using Microsoft.EntityFrameworkCore;
using Back_end_PIB_Cubatão.Models;

namespace Back_end_PIB_Cubatão.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sermao> Sermoes { get; set; }
        public DbSet<Igreja> Igrejas { get; set; }
        public DbSet<Membro> Membros { get; set; }
        public DbSet<Ministerio> Ministerios { get; set; }
        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<Pagina> Paginas { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<Eventos> Eventoss { get; set; }
    }
}

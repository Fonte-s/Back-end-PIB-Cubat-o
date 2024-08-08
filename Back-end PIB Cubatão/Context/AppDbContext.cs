using Microsoft.EntityFrameworkCore;
using Back_end_PIB_Cubatão.Models;
using static Back_end_PIB_Cubatão.Models.Membro;

namespace Back_end_PIB_Cubatão.Context
{
    public class AppDbContext : DbContext
    {
        internal object Igreja;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Igreja>().HasData(
                new Igreja { IgrejaID = 1, Nome = "Igreja PIB Cubatao", Endereco = "Rua Pedro de Toledo, 137, Vila Santa Rosa Cubatão",
                    Email = "secretaria@pibcubatao.org.br", DataDeFundacao = new DateTime(2000, 1, 1) }
            );

            modelBuilder.Entity<Membro>().HasData(
                new Membro { MembroID = 1, NomeMembro = "João", SobrenomeMembro = "Silva", DataDeNascimento = new DateTime(1985, 5, 15), Email = "joao.silva@example.com", Telefone = "123456789", DataDeCadastro = DateTime.Now, MinisterioID = 1, Status = Status.Ativo }
            );

            modelBuilder.Entity<Sermao>().HasData(
                new Sermao { SermaoID = 1, Titulo = "A Fé que Move Montanhas", MembroID = 1, Data = new DateTime(2024, 1, 1), TextoBiblico = "Mateus 17:20", Descricao = "Sermão sobre a fé", LinkVideo = "https://example.com/sermao1" }
            );

        }

    }
}

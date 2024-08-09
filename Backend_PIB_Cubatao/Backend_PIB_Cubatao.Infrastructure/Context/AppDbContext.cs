using Microsoft.EntityFrameworkCore;
using Backend_PIB_Cubatao.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Backend_PIB_Cubatao.Infrastructure.Context
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
        public DbSet<Eventos> Eventoss { get; set; }
    }

    public class AppIdentityDbContext: IdentityDbContext<Usuario>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            : base(options)
        {
        }
    }
}

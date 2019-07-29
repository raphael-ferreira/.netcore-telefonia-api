using Microsoft.EntityFrameworkCore;

namespace TelefoniaAPI.Models.Data
{
    public class TelefoniaContext : DbContext
    {
        public TelefoniaContext(DbContextOptions<TelefoniaContext> options)
            : base(options)
        {
        }

        public DbSet<Operadora> Operadoras { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<DDD> DDDs { get; set; }

        public TelefoniaContext(DbSet<DDD> ddds, DbSet<Operadora> operadoras)
        {
            DDDs = ddds;
            Operadoras = operadoras;
        }
    }
}

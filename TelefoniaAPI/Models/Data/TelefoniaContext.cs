using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TelefoniaAPI.Models.Data
{
    public class TelefoniaContext : DbContext
    {
        public TelefoniaContext(DbContextOptions<TelefoniaContext> options)
            : base(options)
        {
        }

        public DbSet<Plano> Planos { get; set; }
    }
}

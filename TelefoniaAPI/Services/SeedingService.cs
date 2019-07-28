using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelefoniaAPI.Models;
using TelefoniaAPI.Models.Data;
using TelefoniaAPI.Models.Enums;

namespace TelefoniaAPI.Services
{
    public class SeedingService
    {
        private TelefoniaContext _context;

        public SeedingService(TelefoniaContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Planos.Any())
            {
                return;
            }

            Plano p1 = new Plano(1, 1000, 10, 54.99, Tipo.Controle, "Tim");
            Plano p2 = new Plano(2, 500, 2, 20.99, Tipo.Pre, "Oi");
            Plano p3 = new Plano(3, 2000, 5, 49.99, Tipo.Pos, "Tim");
            Plano p4 = new Plano(4, 600, 3, 19.99, Tipo.Pre, "Oi");
            Plano p5 = new Plano(5, 700, 3, 14.99, Tipo.Pre, "Oi");
            Plano p6 = new Plano(6, 200, 2, 7.99, Tipo.Pre, "Claro");
            Plano p7 = new Plano(7, 3000, 15, 20.00, Tipo.Pos, "Claro");
            Plano p8 = new Plano(8, 5000, 20, 50.00, Tipo.Pos, "Vivo");
            Plano p9 = new Plano(9, 800, 4, 34.99, Tipo.Controle, "Vivo");
            Plano p10 = new Plano(10, 400, 2, 15.00, Tipo.Pre, "Tim");

            _context.Planos.AddRange(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            _context.SaveChanges();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
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

            Operadora tim = new Operadora(41, "Tim");
            Operadora claro = new Operadora(21, "Claro");
            Operadora vivo = new Operadora(15, "Vivo");
            Operadora oi = new Operadora(31, "Oi");

            _context.Operadoras.AddRange(tim, claro, vivo, oi);

            Plano p1 = new Plano(1, 1000, 10, 54.99, TipoPlano.Controle, tim, new List<int> { 21, 22, 24, 11, 85 });
            Plano p2 = new Plano(2, 500, 2, 20.99, TipoPlano.Pre, oi, new List<int> { 21, 22, 85 });
            Plano p3 = new Plano(3, 2000, 5, 49.99, TipoPlano.Pos, tim, new List<int> { 21, 22, 11 });
            Plano p4 = new Plano(4, 600, 3, 19.99, TipoPlano.Pre, oi, new List<int> { 21, 85 });
            Plano p5 = new Plano(5, 700, 3, 14.99, TipoPlano.Pre, oi, new List<int> { 21, 11 });
            Plano p6 = new Plano(6, 200, 2, 7.99, TipoPlano.Pre, claro, new List<int> { 21, 24, 85 });
            Plano p7 = new Plano(7, 3000, 15, 20.00, TipoPlano.Pos, claro, new List<int> { 21, 24, 11 });
            Plano p8 = new Plano(8, 5000, 20, 50.00, TipoPlano.Pos, vivo, new List<int> { 21, 24, 85 });
            Plano p9 = new Plano(9, 800, 4, 34.99, TipoPlano.Controle, vivo, new List<int> { 21, 24, 11 });
            Plano p10 = new Plano(10, 400, 2, 15.00, TipoPlano.Pre, tim, new List<int> { 21, 24, 85 });

            _context.Planos.AddRange(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

            _context.SaveChanges();      
        }
    }
}

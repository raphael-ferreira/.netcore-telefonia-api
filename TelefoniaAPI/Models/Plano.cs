using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TelefoniaAPI.Models.Enums;

namespace TelefoniaAPI.Models
{
    public class Plano
    {
        [Key]
        public int Codigo { get; set; }
        public int Minutos { get; set; }
        public int Franquia { get; set; }
        public double Valor { get; set; }        
        public string Tipo { get; set; }
        public string Operadora { get; set; }
        public List<DDD> DDDs { get; set; }

        public Plano()
        {

        }

        public Plano(int codigo, int minutos, int franquia, double valor, TipoPlano tipo, Operadora operadora, List<int> ddd)
        {
            Codigo = codigo;
            Minutos = minutos;
            Franquia = franquia;
            Valor = valor;
            Tipo = tipo.ToString();
            Operadora = operadora.Descricao;

            List<DDD> list = new List<DDD>();
            ddd.ForEach(d => list.Add(new DDD(d)));

            DDDs = list;
        }
    }
}

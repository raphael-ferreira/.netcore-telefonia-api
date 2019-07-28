using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
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
        public Tipo Tipo { get; set; }
        public string Operadora { get; set; }

        public Plano()
        {

        }

        public Plano(int codigo, int minutos, int franquia, double valor, Tipo tipo, string operadora)
        {
            Codigo = codigo;
            Minutos = minutos;
            Franquia = franquia;
            Valor = valor;
            Tipo = tipo;
            Operadora = operadora;
        }
    }
}

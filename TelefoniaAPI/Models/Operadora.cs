using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaAPI.Models
{
    public class Operadora
    {
        [Key]
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public Operadora(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}

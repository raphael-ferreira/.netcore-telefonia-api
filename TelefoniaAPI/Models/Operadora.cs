using System.ComponentModel.DataAnnotations;

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

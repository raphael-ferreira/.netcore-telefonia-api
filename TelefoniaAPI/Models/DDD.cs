using System.ComponentModel.DataAnnotations;

namespace TelefoniaAPI.Models
{
    public class DDD
    {
        [Key]       
        public int _id { get; set; }
        public int CodigoDDD { get; set; }

        public DDD(int codigoDDD)
        {
            CodigoDDD = codigoDDD;
        }
    }
}

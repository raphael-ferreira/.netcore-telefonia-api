using System.ComponentModel;

namespace TelefoniaAPI.Models.Enums {
    public enum TipoPlano {
        [Description("Controle")]
        [DisplayName("Controle")]
        Controle,
        [Description("Pós")]
        [DisplayName("Pós")]
        Pos,
        [Description("Pré")]
        [DisplayName("Pré")]
        Pre
    }
}

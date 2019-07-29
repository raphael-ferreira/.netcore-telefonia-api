using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

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

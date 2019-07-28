using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TelefoniaAPI.Models.Enums {
    public enum TipoPlano {
        [Description("Controle")]
        Controle,
        [Description("Pós")]
        Pos,
        [Description("Pré")]
        Pre
    }
}

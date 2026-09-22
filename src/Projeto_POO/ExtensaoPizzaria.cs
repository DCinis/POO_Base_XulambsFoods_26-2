using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods {
    public static class ExtensaoPizzaria {
        public static double Valor(this EBorda borda) {
            return borda switch {
                EBorda.Chocolate => 8,
                EBorda.Cheddar => 10,
                EBorda.Requeijao => 7,
                _ => 0
            };
        }
    }
}

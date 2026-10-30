using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    internal class Bebida : Alimento
    {
        EBebida _tipo;
        public override double CalcularValorFinal()
        {
            return _tipo.Valor();
        }
    }
}

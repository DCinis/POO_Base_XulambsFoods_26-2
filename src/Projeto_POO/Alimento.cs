using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsFoods
{
    public abstract class Alimento
    {

        protected string _descricao;
        public Alimento() {}
        public abstract double CalcularValorFinal();
    }
}

using System;


namespace XulambsFoods
{
    public class Pizza
    {
        /// Lembre-se:
        // ENTENDER O PROBLEMA!!!
        //Regra 0 -- não entre em pânico
        //Regra 1 -- não viaje
        private const int MaxIngredientes = 8;
        private const double PrecoBase = 29;
        private const double ValorPorAdicional = 5;

        
        private int quantIngredientes;
        private string descricao;
        public Pizza()
        {
            Init(0);
        }
        public Pizza(int q)
        {
            Init(q);
        }
        private void Init(int q)
        {
            descricao = "Pizza padrão";
            quantIngredientes = AdicionarIngredientes(q);
        }
        private double ValorAdicionais()
        {
            return ValorPorAdicional * quantIngredientes;
        }
        private string ModificarDescricao()
        {
            return $"Pizza com {quantIngredientes} adicionais";
        }
        private bool PodeAdicionar(int q)
        {
            if (quantIngredientes + q <= 8 && q > 0) return true;
            return false;
        }
        private double CalcularValorFinal()
        {
            return PrecoBase + ValorAdicionais();
        }
        public int AdicionarIngredientes(int q)
        {
            if (PodeAdicionar(q)) quantIngredientes += q;
            ModificarDescricao();
            return quantIngredientes;
        }
        public string GerarCupom()
        {
            return descricao +"\nValor final: " + CalcularValorFinal();
        }

    }
}
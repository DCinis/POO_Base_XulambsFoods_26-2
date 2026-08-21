using System;


namespace XulambsFoods
{
    public class Pizza
    {
        /// Lembre-se:
        // ENTENDER O PROBLEMA!!!
        //Regra 0 -- não entre em pânico
        //Regra 1 -- não viaje
        int maxIngredientes;
        double precoBase;
        int quantIngredientes;
        double valorPorAdicional;
        string descricao;
        public Pizza()
        {
            Init(0);
        }
        public Pizza(int q)
        {
            Init(q);
        }
        void Init(int q)
        {
            descricao = "Pizza padrão";
            precoBase = 29;
            quantIngredientes = AdicionarIngredientes(q);
            valorPorAdicional = 5;
        }
        double ValorAdicionais()
        {
            return valorPorAdicional * quantIngredientes;
        }
        string ModificarDescricao()
        {
            return $"Pizza com {quantIngredientes} adicionais";
        }
        bool PodeAdicionar(int q)
        {
            if (quantIngredientes + q <= 8 && q > 0) return true;
            return false;
        }
        public double CalcularValorFinal()
        {
            return precoBase + ValorAdicionais();
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
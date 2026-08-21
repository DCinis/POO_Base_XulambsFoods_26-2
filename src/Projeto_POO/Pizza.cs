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
            precoBase = 29;
            quantIngredientes = 0;
            AdicionarIngredientes(q);
            valorPorAdicional = 5;
            descricao = "Pizza padrão";
        }
        double ValorAdicionais()
        {
            return valorPorAdicional * quantIngredientes;
        }
        void ModificarDescricao(string desc)
        {
            descricao = desc;
        }
        bool PodeAdicionar(int q)
        {
            if (quantIngredientes + q < 8 && q > 0) return true;
            return false;
        }
        public double CalcularValorFinal()
        {
            return precoBase + ValorAdicionais();
        }
        public void AdicionarIngredientes(int q)
        {
            if (PodeAdicionar(q)) quantIngredientes += q;
            else throw new Exception("Quantidade de ingredientes inválida");
        }
        public string GerarCupom()
        {
            return descricao + "\n" + "Valor final: " + CalcularValorFinal();
        }

    }
}
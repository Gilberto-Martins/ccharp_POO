using System;

namespace exemploPOO.model
{
    public class retangulo
    {
        private double largura;
        private double comprimento;
        private bool validador;

        public void definirValores(double larg, double comp)
        {
            if (larg > 0 && comp > 0)
            {
                validador = true;
                this.comprimento = comp;
                this.largura = larg;
            }
            else
            {
                Console.WriteLine("Não aceita valores negativos!!");
            }
        }

        public double Area()
        {
            if (validador)
            {
                return comprimento * largura;
            }
            else
            {
                Console.WriteLine("Ensira valores positivos!!");
                return 0;
            }
        }
    }
}
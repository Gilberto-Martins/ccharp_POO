namespace exemploPOO.model
{
    public class retangulo
    {
        private double largura;
        private double comprimento;

        public void definirValores(double larg, double comp)
        {
            this.comprimento = comp;
            this.largura = larg;
        }

        public double Area()
        {
            return comprimento * largura;
        }
    }
}
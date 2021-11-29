using exemploPOO.Interfaces;

namespace exemploPOO.model
{
    public class Calculadora : ICalculadora
    {
        public double Divd(double nub1, double nub2)
        {
            return nub1 / nub2;
        }

        public double Mult(double nub1, double nub2)
        {
            return nub1 * nub2;
        }

        public double Soma(double nub1, double nub2)
        {
            return nub1 + nub2;
        }

        public double Subt(double nub1, double nub2)
        {
            return nub1 - nub2;
        }
    }
}
using System;

namespace exemploPOO.model
{
    // para declarar que uma classe é abistrata basta inserir antes da class a "abstract"
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor);

        public void Saldo()
        {
            Console.WriteLine("Saldo: " + saldo);
        }
    }
}
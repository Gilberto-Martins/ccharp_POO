using System;
using exemploPOO.model;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Console.Write("Digite seu nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            p1.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            p1.apresentar();
        }
    }
}

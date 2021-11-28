using System;
using exemploPOO.model;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Pessoa p1 = new Pessoa();
            Console.Write("Digite seu nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            p1.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            p1.apresentar();
            */


            //encapisulamento
            retangulo ret = new retangulo();
            Console.Write("Digite um valor em decimal para largura: ");
            double comp1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um valor em decimal para o comprimento: ");
            double larg1 = Convert.ToDouble(Console.ReadLine());

            ret.definirValores(comp1,larg1);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("O valor da area é: " + ret.Area());
        }
    }
}

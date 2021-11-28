using System;
using exemploPOO.model;

namespace exemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Pessoa p1 = new Pessoa("Gilberto", 22);
            /*
            Pessoa p1 = new Pessoa();

            
            Console.Write("Digite seu nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            p1.idade = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            p1.apresentar();
            */

            // Herança
            Aluno al1 = new Aluno();
            Console.Write("Nome: ");
            al1.nome = Console.ReadLine();

            Console.WriteLine(" ");

            Console.Write("Idade: ");
            al1.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite seu ano de Curso: ");
            al1.anoCurso = Console.ReadLine();
            
            al1.apresentar();

            //Encapisulamento
            /*
            retangulo ret = new retangulo();
            Console.Write("Digite um valor em decimal para largura: ");
            double comp1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um valor em decimal para o comprimento: ");
            double larg1 = Convert.ToDouble(Console.ReadLine());

            ret.definirValores(comp1,larg1);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("O valor da area é: " + ret.Area());
            */
        }
    }
}

using System;

namespace exemploPOO.model
{
    public class Aluno : Pessoa
    {
        public double nota {get; set;}
        public string anoCurso {get; set;}

        public override void apresentar()
        {
            Console.WriteLine($"Meu nome é {nome} tenho {idade} anos estou no {anoCurso} ano com nota {nota}");
        }
    }
}
using System;

namespace exemploPOO.model
{
    public class Professor : Pessoa
    {
        public double salario {get; set;}
        public string materia {get; set;}
        protected int registoProf {get; set;}

        public sealed override void apresentar()
        {
            Console.WriteLine($" Ola, meu nome é {base.nome} e sou professor, ganho {this.salario}, leciono a materia {this.materia}");
        }
    }
}
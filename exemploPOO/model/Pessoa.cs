using System;

namespace exemploPOO.model
{
    public class Pessoa
    {
        public string nome  {   get;    set; }
        public int idade {  get;    set;    }



        //Constutor
        //defini que quando instanciar uma classe você pode definir seu atributos
        //pode ter mais de um construtor
        //se não definir um construtor o programa vai usar um por padrão, que não precissa especificar
        //os valores dos atributos
        public Pessoa (string Nome, int Idade)
        {
            this.nome = Nome;
            this.idade = Idade;
        }

        

        //metodos
        public void apresentar()
        {
            Console.WriteLine("meu nome é "+nome+" e tenho "+idade+" anos.");
        }
    }
}
using System;

namespace exemploPOO.model
{
    public class Pessoa
    {
        public string nome  {   get;    set; }
        public int idade {  get;    set;    }

        public void apresentar()
        {
            Console.WriteLine("meu nome é "+nome+" e tenho "+idade+" anos.");
        }
    }
}
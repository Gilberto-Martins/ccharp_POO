using System;

namespace exemploPOO.model
{
    public class Corrente : Conta
    {
       public override void Creditar(double valor)
       {
           //vamos referenciar a propriedade saldo da class mão usando a palavra reservada "base" o this é para propriedades da propria classe o this tambem funciona no lugar do base

           base.saldo = valor;
       }
    }
}
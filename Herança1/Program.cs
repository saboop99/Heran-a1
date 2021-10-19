using System;
//RAFAEL DO NASCIMENTO RODRIGUES RA 210211

namespace Herança1
{
    class Program
    {
        //Necessário para fazer o programa rodar
        static void Main(string[] args)
        {
            //Instanciando objetos dentro da ContaJuridica ( "int Numero", "string Titular", "double Saldo", "double EmprestimoLimite")
            ContaJuridica conta = new ContaJuridica(8010, "Lara Croft", 100.0, 500.0);
            //Escrever na tela o valor do Saldo
            Console.WriteLine(conta.Saldo);
        }
    }


}

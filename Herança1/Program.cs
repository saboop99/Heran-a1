using System;
//RAFAEL DO NASCIMENTO RODRIGUES RA 210211

namespace Herança1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaJuridica conta = new ContaJuridica(8010, "Lara Croft", 100.0, 500.0);
            Console.WriteLine(conta.Saldo);
        }
    }


}

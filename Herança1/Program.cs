using System;
//RAFAEL DO NASCIMENTO RODRIGUES RA 210211

namespace Herança1
{
    class Program
    {
        //Necessário para fazer o programa rodar
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Goku", 0.0);
            ContaJuridica bacc = new ContaJuridica(1002, "Goten", 0.0, 500.0);
           

           /* Conta acc1 = bacc;
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 200.0);
            Conta acc3 = new ContaPoupança(1004, "Vegeta", 0.0, 0.01);

            ContaJuridica acc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100.0);
            if (acc3 is ContaJuridica)
            {
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }

            if (acc3 is ContaPoupança)
            {
                ContaPoupança acc5 = acc3 as ContaPoupança;
                acc5.atualizaçãoSaldo();
                Console.WriteLine("Atualizado!");
            }*/
        }
          
        
    }
    

}

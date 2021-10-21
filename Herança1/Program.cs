using System;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211

namespace Herança1
{
    class Program
    {
        //Necessário para fazer o programa rodar
        static void Main(string[] args)
        {
            //criação da conta poupança CP com parametros           
            ContaPoupança CP = new ContaPoupança(1000, "LOKI", 10.0, 0.01);

            //chamar o metodo saque
            CP.Saque(0);

            //imprimir o valor atualizado do saldo
            Console.WriteLine(CP.Saldo);

            
            

      
           /* //Upcasting
            Conta acc1 = bacc;
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 200.00);
            Conta acc3 = new ContaJuridica(1004, "Vegeta", 0.0, 0.01);

            //Downcasting
            ContaJuridica acc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100.0);

            if (acc3 is ContaJuridica)
            {
                //ContaPoupanca acc5 = (ContaPoupanca)acc3;
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }

            if (acc3 is ContaPoupança)
            {
                //ContaPoupanca acc5 = (ContaPoupanca)acc3;
                ContaPoupança acc5 = acc3 as ContaPoupança;
                acc5.atualizaçãoSaldo();
                Console.WriteLine("Atualizado!");
            }*/
            


        }


    }


}
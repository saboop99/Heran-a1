using System;
using System.Globalization;
using System.Collections.Generic;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211

namespace Herança1
{
    class Program
    {
        //Necessário para fazer o programa rodar
        static void Main(string[] args)
        {
            //criação de uma lista(numero da conta, nome, saldo, taxa de juros para as poupanças e emprestimo pras juridicas
            List<Conta> list = new List<Conta>();
            list.Add(new ContaPoupança(1001, "Woody", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "Andy", 500.0, 400.0));
            list.Add(new ContaPoupança(1003, "Buzz", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "Bullseye", 500.0, 400.0));

            //criação da variavel soma com o valor 0 para ir adicionando
            double soma = 0.0;
            //foreach para ir somando o Saldo de cada conta na lista
            foreach (Conta acc in list)
            {
                soma += acc.Saldo;
            }

            // escrever na tela o saldo total de toda as contas, que é o valor da variavel soma
            Console.WriteLine("Total do saldo de todas as contas: " + soma.ToString("F2", CultureInfo.InvariantCulture));
            //foreache para chamar o Saque de cada conta na lista
            foreach (Conta acc in list)
            {
                acc.Saque(10.0);
            }

            //foreach para atualizar o usuário com todos os resultados das contas da lista após saque (numero da conta, Saldo atualizado)
            foreach (Conta acc in list)
            {
                Console.WriteLine("Atualização do saldo das contas "
                + acc.Numero + ": " + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        
        
        }


    }


}
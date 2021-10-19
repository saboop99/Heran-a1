using System;
using System.Collections.Generic;
using System.Text;
//RAFAEL DO NASCIMENTO RODRIGUES RA 210211

namespace Herança1
{
    //criação da subclasse ContaJuridica, que herda a classe Conta
    class ContaJuridica: Conta
    {
        //Declaração e encapsulamento da variável EmprestimoLimite
        public double EmprestimoLimite { get; set; }

        //Construtor Padrão
        public ContaJuridica() 
        {
            
        }
        //Construtor personalizado com parâmetros da Classe herdada (Conta)
        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        //Condicional e Operação para saber o valor do Emprestimo (também utilizando elementos da classe Conta)
        public void Emprestimo(double saldoTotal)
        {
            //Condicional
            if (saldoTotal <= EmprestimoLimite)
            {
                //Operação
                Saldo += saldoTotal;
            }
        }
    }
}

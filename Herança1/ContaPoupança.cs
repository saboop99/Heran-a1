using System;
using System.Collections.Generic;
using System.Text;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Herança1
{
    class ContaPoupança: Conta
    {

        //Declaração e encapsulamento da variável TaxaJuros
        public double TaxaJuros { get; set; }
        
        //Construtor Padrão
        public ContaPoupança()
        {

        }

        //método construtor personalizado com parâmetros
        public ContaPoupança(int numero, string titular, double saldo, double taxajuros) 
            : base(numero, titular, saldo)
        {
            {
                TaxaJuros = taxajuros;
            }
        }


        //operação matemátca para saber o valor do saldo atualizado
        public void atualizaçãoSaldo()
        {
            
            Saldo += Saldo * TaxaJuros;
        }

        //Override para saber o Saque
        public override void Saque(double saldoTotal)
        {
            //Saldo -= saldoTotal;
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

//RAFAEL DO NASCIMENTO RODRIGUES RA 210211
namespace Herança1
{
    class ContaPoupança: Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupança()
        {

        }

        public ContaPoupança(int numero, string titular, double saldo, double taxajuros) 
            : base(numero, titular, saldo)
        {
            {
                TaxaJuros = taxajuros;
            }
        }
        

        public void atualizaçãoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
        
        public override void Saque(double saldoTotal)
        {
            //Saldo -= saldoTotal;
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }
    }
}

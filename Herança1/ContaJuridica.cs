using System;
using System.Collections.Generic;
using System.Text;
//RAFAEL DO NASCIMENTO RODRIGUES RA 210211

namespace Herança1
{
    class ContaJuridica: Conta
    {
        public double EmprestimoLimite { get; set; }

        public ContaJuridica() { }
        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        public void Emprestimo(double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
//RAFAEL DO NASCIMENTO RODRIGUES RA 210211

namespace Herança1
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }


        public Conta()
        {

        }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }

        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}

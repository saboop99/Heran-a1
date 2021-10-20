using System;
using System.Collections.Generic;
using System.Text;
//RAFAEL DO NASCIMENTO RODRIGUES RA 210211

namespace Herança1
{
    //criação da classe Conta
    class Conta
    {
        //Declaração e encapsulamento da variável Numero
        public int Numero { get; private set; }
        //Declaração e encapsulamento da variável Titular
        public string Titular { get; private set; }
        //Declaração e encapsulamento da variável Saldo (utilização do protected por necessidade de cuidado sobre a proteção de informações)
        public double Saldo { get; protected set; }


        //método construtor padrão
        public Conta()
        {

        }
        //método construtor personalizado com parâmetros
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        //Operação matemática para saber o valor do Saque (virtual para permitir override)
        public virtual void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal + 5.0;
        }

        //operação matemátca para saber o valor do Depósito
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}

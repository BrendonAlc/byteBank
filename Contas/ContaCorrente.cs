using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{

    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set;} //setando set como private para não haver falha de autenticação, assim não podendo ser inserido valores inválidos.
        public Cliente Titular { get; }

        private string nome_agencia;
        private int numero_agencia;
        public int Numero_agencia //Propriedade para acessar numero_agencia como public
        {
            get { return this.numero_agencia;}
            private set { //setando como private para ficar visível somente dentro da própria classe
                    if ( value > 0)
                    {
                        this.numero_agencia = value;
                    }
                }
        }

        //private string conta;
        public string? Conta { get; set;} //Propriedade autoincrementada
        private double saldo = 100;
        
        private Cliente titular { get; set;}


        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Saque(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

//método de tranferencia
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.Saque(valor);
                destino.Depositar(valor);
                return true;
            }
        }

//método para definir saldo
        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

//método para obter saldo que está privada
        public double GetSaldo()
        {
            return this.saldo;
        }

//Contrutor de conta corrente, para que informe o numero_agencia e numero_conta
        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }


//Construtor de ContaCorrente
        public ContaCorrente(Cliente titular, string nome_agencia, int numero_agencia, string conta)
        {
            Titular = titular;
            this.nome_agencia = nome_agencia;
            Numero_agencia = numero_agencia;
            Conta = conta;

        }



//Método para exibir dados da conta
        public void ExibirDadosDaConta()
        {
            Console.WriteLine($"Nome Agência: {nome_agencia}");
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Número da Agência: {numero_agencia}");
            Console.WriteLine($"Conta: {Conta} ");
            Console.WriteLine("Saldo :" + saldo);
        }
    }
}
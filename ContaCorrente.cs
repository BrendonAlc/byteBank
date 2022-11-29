using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{

    public class ContaCorrente
    {
        public string nome_agencia;
        public int numero_agencia;
        public string conta;
        public double saldo = 100;
        
        public Cliente titular;


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

        public void ExibirDadosDaConta()
        {
            System.Console.WriteLine($"Nome Agência: {nome_agencia}");
            System.Console.WriteLine($"Titular: {titular}");
            System.Console.WriteLine($"Número da Agência: {numero_agencia}");
            System.Console.WriteLine($"Conta: {conta} ");
            System.Console.WriteLine("Saldo :" + saldo);
        }
    }
}
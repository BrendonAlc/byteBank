using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public abstract class Funcionario //implementar classe funcionario como abstrata
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; } //private para não atribuir diretamente no atributo dados
        public double Salario { get; protected set; } //private para não atribuir diretamente no atributo dados ou protected para que eu possa atribuir a outras classes

        public static int TotalDeFuncionarios { get; private set; }

        //metodo para bonificação
        public abstract double GetBonificacao();

//Construtor para incrementar a quantidade de funcionário
        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalDeFuncionarios++;
            //System.Console.WriteLine("Criando um Funcionário.");
        }

        public abstract void AumentarSalario();
    }
}
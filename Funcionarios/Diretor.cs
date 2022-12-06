using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Diretor : Funcionario //herdando tipos de dados do funcionario para diretor
    {

//Criar método publico para acessar campo privado da classe GerenciadorDeBonificacao
        public override double GetBonificacao() //override é uma permissão para redefinir a escrita
        {
            return this.Salario * 0.5;
        }

        public Diretor(string cpf): base(cpf, 5000)
        {
            //System.Console.WriteLine("Criando um Diretor");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        //método de autenticação do usuario
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}

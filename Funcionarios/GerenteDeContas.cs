using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }

        //Acessando get da classe funcionario e redefinindo bonificação para está classe
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        //Acessando get da classe funcionario e redefinindo AumentarSalario para esta classe
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        //método de autenticação do usuario
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
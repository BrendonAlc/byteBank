using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {

        }

        //Acessando get da classe funcionario e redefinindo bonificação para está classe
        public override double GetBonificacao()
        {
            return this.Salario *= 0.17;
        }

        //Acessando get da classe funcionario e redefinindo AumentarSalario para esta classe
        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Funcionario //implementar classe funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        //metodo para bonificação
        public double GetBonificacao()
        {
            return this.Salario * 0.10;
        }
    }
}
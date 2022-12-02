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
        public double GetBonificacao()
        {
            return this.Salario;
        }
    }
}

using bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.SistemaInterno
{
    public class SistemaInterno
    {
        //método de autenticação para Diretor no sistema
        public bool Logar(Diretor funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                System.Console.WriteLine("Boas vindas ao nosso sistema.");
                return true;
            }
            else
            {
                System.Console.WriteLine("Senha incorreta!");
                return false;
            }
        }

        //método de autenticação para GerenteDeContas no sistema
        public bool Logar(GerenteDeContas funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                System.Console.WriteLine("Boas vindas ao nosso sistema.");
                return true;
            }
            else
            {
                System.Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
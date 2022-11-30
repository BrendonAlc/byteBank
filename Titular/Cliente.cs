using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    //Criando e detalhando classe do titular da conta
    public class Cliente
    {
        // private string _nome;
        // public string Nome //Propriedade para acessar _nome que consta como private
        // {
        //     get
        //     {
        //         return _nome;
        //     }
        //     set
        //     {
        //         if (value.Length < 3)
        //         {
        //             Console.WriteLine("Nome do Titular deve conter pelo menos 3 caracteres");
        //         }
        //         else
        //         {
        //             _nome = value;
        //         }
        //     }
        // }

        // public string cpf;
        // public string profissao;

        //Criando propriedades publicas com autoincremento

        public string Nome { get; set;}
        public string Cpf { get; set;}
        public string Profissao { get; set;}

        public static int TotalClientesCadastrados { get; set;}
        
        public Cliente()
        {
            TotalClientesCadastrados++;
        }
    }
}
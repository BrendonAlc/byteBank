using bytebank.SistemaInterno;
using bytebank;
using bytebank.Titular;
using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.Utilitario;

#region teste1
// ContaCorrente contaDoBrendon = new ContaCorrente();
// contaDoBrendon.nome_Agencia = "ByteBank Pinhais";
// contaDoBrendon.titular = "Brendon Rodrigo";
// contaDoBrendon.numero_Agencia = 15;
// contaDoBrendon.conta = "1010-X";
// contaDoBrendon.saldo = 350;
// System.Console.WriteLine("Saldo da conta do Brendon é: " +contaDoBrendon.saldo);

// ContaCorrente contaDoBrendon2 = new ContaCorrente();
// contaDoBrendon2.nome_Agencia = "ByteBank Centro";
// contaDoBrendon2.titular = "Brendon Rodrigo";
// contaDoBrendon2.numero_Agencia = 15;
// contaDoBrendon2.conta = "1010-X";
// contaDoBrendon2.saldo = 350;
// System.Console.WriteLine("Saldo da conta do Brendon é: " +contaDoBrendon2.saldo);

// System.Console.WriteLine(contaDoBrendon == contaDoBrendon2);

// // Console.WriteLine("Saldo da conta do Brendon é:" +contaDoBrendon.saldo);

// // contaDoBrendon.Depositar(100);
// // Console.WriteLine("Seu saldo é: " +contaDoBrendon.saldo);

// // contaDoBrendon.Saque(50);
// // Console.WriteLine("Seu saldo é: " +contaDoBrendon.saldo);

// // Console.WriteLine($"Titular da conta: {contaDoBrendon.titular}");
// // Console.WriteLine($"Número da conta: {contaDoBrendon.conta}");
// // Console.WriteLine($"Agência: {contaDoBrendon.numero_Agencia}");
// // Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDoBrendon.saldo)}");

// // Console.ReadKey();


// // //If para verificação de saldo em conta
// // if(contaDoBrendon.Saque(300) == true)
// // {
// //     Console.WriteLine("Saldo da conta do Brendon após o saque: " + contaDoBrendon.saldo);
// // }
// // else
// // {
// //     Console.WriteLine("Saldo insuficiente para saque!");
// // }

// ContaCorrente contaDaMaria = new ContaCorrente();
// contaDaMaria.titular = "Maria Souza";
// contaDaMaria.numero_Agencia = 17;
// contaDaMaria.conta = "1010-5";
// contaDaMaria.saldo = 100;

// Console.WriteLine("Saldo da Maria: " + contaDaMaria.saldo);

// contaDoBrendon.Transferir(50, contaDaMaria);
// Console.WriteLine("Saldo do Brendon: " + contaDoBrendon.saldo);
// Console.WriteLine("Saldo da Maria: " + contaDaMaria.saldo);


// ContaCorrente contaDoPedro = new ContaCorrente();
// contaDoPedro.titular = "Pedro Silva";
// System.Console.WriteLine(contaDoPedro.titular);
// System.Console.WriteLine(contaDoPedro.saldo);
// System.Console.WriteLine(contaDoPedro.numero_Agencia);
// System.Console.WriteLine(contaDoPedro.conta);

//**Tipos por valor**//

// double valor = 300;
// double valor2 = valor;


//Iniciando Objeto

// Cliente cliente = new Cliente();
// cliente.nome = "Brendon Rodrigo";
// cliente.cpf = "114455689";
// cliente.profissao = "Analista";

// ContaCorrente conta = new ContaCorrente();
// conta.titular = cliente;
// conta.conta = "1010-X";
// conta.numero_agencia = 15;
// conta.nome_agencia = "ByteBank Centro";
// conta.saldo = 100;

// System.Console.WriteLine("Titular: " + conta.titular.nome);
// System.Console.WriteLine("Cpf: " + conta.titular.cpf);
// System.Console.WriteLine("Profissão: " + conta.titular.profissao);
// System.Console.WriteLine("Nome da Agência: " + conta.nome_agencia);
// System.Console.WriteLine("Nº da conta: " + conta.conta);
// System.Console.WriteLine("Saldo: " + conta.saldo);

// ContaCorrente conta2 = new ContaCorrente();
// conta2.titular = new Cliente();
// conta2.titular.nome = "José Silva";
// conta2.titular.profissao = "Tester";
// conta2.titular.cpf = "987564215";
// conta2.conta = "9999-X";
// conta2.numero_agencia = 18;
// conta2.nome_agencia = "ByteBank Pinhais";
// conta2.saldo = 500;

// System.Console.WriteLine(conta2.titular.nome);

// ContaCorrente conta4 = new ContaCorrente(18, "1011-H");
// conta4.SetSaldo(200);
// conta4.Titular = new Cliente();
// Console.WriteLine(conta4.GetSaldo());
// Console.WriteLine(conta4.Numero_agencia);

// ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
// System.Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

// ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
// System.Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

// ContaCorrente conta7 = new ContaCorrente(285, "1111-Z");
// System.Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
#endregion 1

#region teste2
// Cliente sarah = new Cliente();
// sarah.Nome = "Sarah Silva";
// sarah.Profissao = "Psicóloga";
// sarah.Cpf = "123456789";

// Cliente ester = new Cliente();
// ester.Nome = "Ester Almeida";
// ester.Profissao = "Analista";
// ester.Cpf = "789456123";

// System.Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);
// System.Console.WriteLine();

// System.Console.WriteLine("----Dados de Funcionarios----");
// Funcionario pedro = new Funcionario("123456789", 2000);
// pedro.Nome = "Pedro malazartes";

// System.Console.WriteLine("Nome:" +pedro.Nome);
// System.Console.WriteLine("Bonificação de: " +pedro.Nome + " será de: " + pedro.GetBonificacao());

// System.Console.WriteLine();

// Diretor luciana = new Diretor("789456123");
// luciana.Nome = "Luciana";
// System.Console.WriteLine("Nome: " + luciana.Nome);
// System.Console.WriteLine("Bonificação de " +luciana.Nome + " será de: " + luciana.GetBonificacao());

// GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
// gerenciador.Registrar(pedro);
// gerenciador.Registrar(luciana);

// System.Console.WriteLine();
// System.Console.WriteLine("-----Bonificações e funcionários-----");

// System.Console.WriteLine("Total de bonificações: " +gerenciador.TotalDeBonificacao);
// System.Console.WriteLine("Total de funcionários: " +Funcionario.TotalDeFuncionarios);

// System.Console.WriteLine();
// System.Console.WriteLine("---Aumento de salário para os colaboradores abaixo---");
// pedro.AumentarSalario();
// luciana.AumentarSalario();

// System.Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);
// System.Console.WriteLine("Novo salário do Luciana: " + luciana.Salario);
#endregion

CalcularBonificacao();
UsarSistema();


//Método para Calcular bonificação
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer brendon = new Designer("123456");
    brendon.Nome = "Brendon Alcantara";

    Diretor luciana = new Diretor("789432");
    luciana.Nome = "Luciana Vieira";

    Auxiliar igor = new Auxiliar("789412");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("675123");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(brendon);
    gerenciador.Registrar(luciana);

    System.Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
}

//Método para usar sistema

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor luciana = new Diretor("789432");
    luciana.Nome = "Luciana Vieira";
    luciana.Senha = "123";

    GerenteDeContas juninho = new GerenteDeContas("789576");
    juninho.Nome = "Juninho Alcantara";
    juninho.Senha = "321";

    sistema.Logar(luciana, "123");
    sistema.Logar(juninho, "987"); 
}
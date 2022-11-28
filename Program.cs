
using bytebank;

ContaCorrente contaDoBrendon = new ContaCorrente();
contaDoBrendon.titular = "Brendon Rodrigo";
contaDoBrendon.numero_Agencia = 15;
contaDoBrendon.conta = "1010-X";
contaDoBrendon.saldo = 350;

// Console.WriteLine("Saldo da conta do Brendon é:" +contaDoBrendon.saldo);

// contaDoBrendon.Depositar(100);
// Console.WriteLine("Seu saldo é: " +contaDoBrendon.saldo);

// contaDoBrendon.Saque(50);
// Console.WriteLine("Seu saldo é: " +contaDoBrendon.saldo);

// Console.WriteLine($"Titular da conta: {contaDoBrendon.titular}");
// Console.WriteLine($"Número da conta: {contaDoBrendon.conta}");
// Console.WriteLine($"Agência: {contaDoBrendon.numero_Agencia}");
// Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDoBrendon.saldo)}");

// Console.ReadKey();


// //If para verificação de saldo em conta
// if(contaDoBrendon.Saque(300) == true)
// {
//     Console.WriteLine("Saldo da conta do Brendon após o saque: " + contaDoBrendon.saldo);
// }
// else
// {
//     Console.WriteLine("Saldo insuficiente para saque!");
// }

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_Agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 100;

Console.WriteLine("Saldo da Maria: " + contaDaMaria.saldo);

contaDoBrendon.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo do Brendon: " + contaDoBrendon.saldo);
Console.WriteLine("Saldo da Maria: " + contaDaMaria.saldo);


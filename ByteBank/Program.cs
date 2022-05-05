using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vinda ao seu banco, ByteBank!");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "Andre Silva";
//conta1.conta = "10123-x";
//conta1.numeroAgencia = 23;
//conta1.nomeAgencia = "Agência Central";
//conta1.saldo = 100.00;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Amanda Nogueira";
//conta2.conta = "10106-x";
//conta2.numeroAgencia = 23;
//conta2.nomeAgencia = "Agência Central";
//conta2.saldo = 100.00;

//Console.WriteLine("Saldo da Amanda pré-saque: " + conta2.saldo);

//bool saque = conta2.Sacar(50);

//Console.WriteLine("Saque realizado? " + saque);

//Console.WriteLine("Saldo da Amanda pós-saque: " + conta2.saldo);

//conta2.Depositar(60);

//Console.WriteLine("Saldo da Amanda pós-deposito: " + conta2.saldo);

//Console.WriteLine("Saldo da Amanda pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André pré-transferência: " + conta1.saldo);

//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferencia realizada com sucesso? " + transferencia);

//Console.WriteLine("Saldo da Amanda pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André pós-transferência: " + conta1.saldo);

//conta1.ExibirDadosDaConta();

//Cliente cliente = new Cliente();
//cliente.nome = "Andre Silva";
//cliente.cpf = "1076546512130";
//cliente.profissao = "Programador C#";

Cliente cliente = new Cliente();

cliente.nome = "Andre Silva";
cliente.cpf = "102579543132";
cliente.profissao = "Programador C#";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = cliente;
conta3.conta = "24654213-x";
conta3.numeroAgencia = 35;
conta3.nomeAgencia = "Agencia Central";

Console.WriteLine(cliente.nome);
Console.WriteLine(conta3.titular.nome);

Console.ReadKey();  
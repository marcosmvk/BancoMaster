using BancoMaster;
using static System.Console;

WriteLine("Escolha qual conta deseja abrir: \n" +
    "\t1 - Conta comum\n" +
    "\t2 - Conta Poupança\n" +
    "\t3 - Conta empresa");

int opcao = int.Parse(Console.ReadLine());  

switch (opcao)
{
    case 1:
        Conta conta;
        Write("Digite o titular da conta: ");
        string titular = ReadLine();
        Write("Digite o número da conta: ");
        int numero = int.Parse(ReadLine());
        Write("Deseja fazer depósito inicial (s/n): ");
        if (char.Parse(ReadLine().ToLower()) == 's')
        {
            Write("Digite o depósito inicial: ");
            double deposito = double.Parse(ReadLine());
            conta = new Conta(numero, titular, deposito);
            WriteLine($"Conta criada com depósito inicial de: {deposito}");
        }
        else 
        {
                conta = new Conta(numero, titular);
        }
        conta.Dados();

        WriteLine("Deseja fazer um saque? (s/n)");
        if (char.Parse(ReadLine().ToLower()) == 's')
        {
            Write("Digite o valor do saque: ");
            double saque = double.Parse(ReadLine());
            conta.Saque(saque);
            WriteLine("Saque realizado com sucesso! Saldo: " + conta.SaldoConta);
        }
    break;
        case 2:
    ContaPoupanca poupanca;
    Write("Digite o titular da conta: ");
    titular = ReadLine();
    Write("Digite o número da conta: ");
    numero = int.Parse(ReadLine());
    Write("Digite a taxa de juros: ");
    double juros = double.Parse(ReadLine());
    Write("Deseja fazer depósito inicial (s/n): ");

    if (char.Parse(ReadLine().ToLower()) == 's')
    {
        Write("Digite o depósito inicial: ");
        double deposito = double.Parse(ReadLine());
        poupanca = new ContaPoupanca(numero, titular, deposito, juros);
    }
    else
    {
        poupanca = new ContaPoupanca(numero, titular, juros);
    }
    poupanca.Dados();
     WriteLine("Deseja fazer um saque? (s/n)");
        if (char.Parse(ReadLine().ToLower()) == 's')
        {
            Write("Digite o valor do saque: ");
            double saque = double.Parse(ReadLine());
            poupanca.Saque(saque);
            WriteLine("Saque realizado com sucesso! Saldo: " + poupanca.SaldoConta);
        }
    break;

case 3:
    ContaParaEmpresa empresa;
    Write("Digite o titular da conta: ");
    titular = ReadLine();
    Write("Digite o número da conta: ");
    numero = int.Parse(ReadLine());
    Write("Digite o limite de empréstimo: ");
    double limite = double.Parse(ReadLine());
    Write("Deseja fazer depósito inicial (s/n): ");

    if (char.Parse(ReadLine().ToLower()) == 's')
    {
        Write("Digite o depósito inicial: ");
        double deposito = double.Parse(ReadLine());
        empresa = new ContaParaEmpresa(numero, titular, deposito, limite);
    }
    else
    {
        empresa = new ContaParaEmpresa(numero, titular, limite);
    }
    empresa.Dados();
    WriteLine("Deseja fazer um emprestimo? (s/n)");
        if (char.Parse(ReadLine().ToLower()) == 's')
        {
            Write("Digite o valor do empréstimo: ");
            double emprestimo = double.Parse(ReadLine());
            empresa.Emprestimo(emprestimo);
            WriteLine("Empréstimo realizado com sucesso! Saldo: " + empresa.SaldoConta);
        }
    
    break;

}

ReadKey();

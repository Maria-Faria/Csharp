Console.WriteLine("""
░░███╗░░░░░
░████║░░░░░
██╔██║░░░░░
╚═╝██║░░░░░
███████╗██╗
╚══════╝╚═╝
""");

Conta conta1 = new Conta();

Console.Write("\nDigite o número da conta: ");
conta1.Numero = int.Parse(Console.ReadLine()!);

Console.Write("Digite o nome do titular da conta: ");
conta1.Titular = Console.ReadLine()!;

Console.Write("Informe o saldo disponível na conta: ");
conta1.Saldo = double.Parse(Console.ReadLine()!);

Console.Write("Digite a senha da conta: ");
conta1.Senha = Console.ReadLine()!;

Console.WriteLine("------------------------------------");
conta1.ExibeDados();

Thread.Sleep(3000);
Console.Clear();

Console.WriteLine("""
        
    ██████╗░░░░
    ╚════██╗░░░
    ░░███╔═╝░░░
    ██╔══╝░░░░░
    ███████╗██╗
    ╚══════╝╚═╝
    """);

Carro carro1 = new Carro();

Console.Write("\nInforme o fabricante do carro: ");
carro1.Fabricante = Console.ReadLine()!;

Console.Write("Digite o modelo do carro: ");
carro1.Modelo = Console.ReadLine()!;

Console.Write("Informe a cor do carro: ");
carro1.Cor = Console.ReadLine()!;

Console.Write("Informe o ano do carro (entre 1960 e 2023): ");
carro1.Ano = int.Parse(Console.ReadLine()!);

Console.WriteLine("------------------------------------");
Console.WriteLine(carro1.DescricaoDetalhada);

Thread.Sleep(3000);
Console.Clear();
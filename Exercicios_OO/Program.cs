/*Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e 
 * saldo no console, utilizando interpolação de strings.*/

Console.WriteLine("""
░░███╗░░░░░
░████║░░░░░
██╔██║░░░░░
╚═╝██║░░░░░
███████╗██╗
╚══════╝╚═╝
""");

Conta conta1 = new Conta();

Console.Write("\nDigite o número indicador da conta: ");
conta1.numero = int.Parse(Console.ReadLine()!);

Console.Write("Digite o nome do titular da conta: ");
conta1.titular = Console.ReadLine()!;

Console.Write("Informe o saldo disponível na conta: R$");
conta1.saldo = double.Parse(Console.ReadLine()!);

Console.Write("Defina a senha da conta: ");
conta1.senha = Console.ReadLine()!;

Console.WriteLine("\n****************************");
conta1.ExibeDados();

Thread.Sleep(3000);
Console.Clear();


/*Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar*/
Console.WriteLine("""
        
    ██████╗░░░░
    ╚════██╗░░░
    ░░███╔═╝░░░
    ██╔══╝░░░░░
    ███████╗██╗
    ╚══════╝╚═╝
    """);

Carro carro1 = new Carro();

carro1.modelo = "Hilux";
carro1.cor = "Preta";
carro1.ano = 2023;

Console.WriteLine();
Console.Write("""
    O que você deseja fazer?

    1. Acelerar
    2. Frear
    3. Buzinar
    4. Exibir ficha técnica do carro cadastrado

    Digite a opção escolhida aqui: 
    """);

int opcao = int.Parse(Console.ReadLine()!);

Console.WriteLine();
switch (opcao)
{
    case 1:
        carro1.Acelerar();
        break;

    case 2:
        carro1.Frear();
        break;

    case 3:
        carro1.Buzinar();
        break;

    case 4:
        carro1.ExibirFicha();
        break;

    default:
        Console.WriteLine("Opção não encontrada!");
        break;
}
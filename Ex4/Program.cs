//Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

Console.WriteLine("""
░░███╗░░░░░
░████║░░░░░
██╔██║░░░░░
╚═╝██║░░░░░
███████╗██╗
╚══════╝╚═╝
""");

Dictionary<string, List<double>> alunos = new Dictionary<string, List<double>>(); //criando o dicionário

alunos.Add("Maria Eduarda", new List<double>{8.8, 9, 7, 5});

Console.WriteLine("\nNotas da aluna Maria Eduarda: ");

foreach(double nota in alunos["Maria Eduarda"])
{
    Console.WriteLine(nota);
}

Console.WriteLine($"\nMédia: {alunos["Maria Eduarda"].Average()}");
Thread.Sleep(3000);
Console.Clear();

//Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre,
//a partir do nome de um produto, sua quantidade em estoque.

Console.WriteLine("""
    
    ██████╗░░░░
    ╚════██╗░░░
    ░░███╔═╝░░░
    ██╔══╝░░░░░
    ███████╗██╗
    ╚══════╝╚═╝
  """);

Dictionary<string, int> produtos = new Dictionary<string, int>();

produtos.Add("Relógio", 5);
produtos.Add("Borracha", 25);
produtos.Add("Colar", 10);

Console.Write("\nDigite o nome do produto que deseja consultar: ");
string nomeProduto = Console.ReadLine()!;

if(produtos.ContainsKey(nomeProduto))
{
    Console.WriteLine($"Estoque de {nomeProduto}: {produtos[nomeProduto]} unidades");

}else
{
    Console.WriteLine("Produto não encontrado!");
}

Thread.Sleep(3000);
Console.Clear();

//Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e
//as respostas corretas.

Console.WriteLine("""
        
    ██████╗░░░░
    ╚════██╗░░░
    ░█████╔╝░░░
    ░╚═══██╗░░░
    ██████╔╝██╗
    ╚═════╝░╚═╝
    """);

Dictionary<int, char> respostas = new Dictionary<int, char>();

respostas.Add(1, 'c');
respostas.Add(2, 'e');
respostas.Add(3, 'd');

int questao = 1;

Console.WriteLine("\n1. Na saga Harry Potter, qual é o nome do primo do protagonista?");
Console.WriteLine("a. João");
Console.WriteLine("b. Jorge");
Console.WriteLine("c. Duda");
Console.WriteLine("d. Carlos");
Console.WriteLine("e. Cadu");

Console.Write("\nDigite sua resposta: ");
char resposta = char.Parse(Console.ReadLine()!);

CertoOuErrado(questao, resposta);
questao++;

Console.WriteLine("\n2. Marque a alternativa correspondente a uma obra de Machado de Assis: ");
Console.WriteLine("a. A Hora da Estrela");
Console.WriteLine("b. Crime e Castigo");
Console.WriteLine("c. Capitães de Areia");
Console.WriteLine("d. Orgulho e Preconeito");
Console.WriteLine("e. Memórias Póstumas de Brás Cubas");

Console.Write("\nDigite sua resposta: ");
resposta = char.Parse(Console.ReadLine()!);

CertoOuErrado(questao, resposta);
questao++;

Console.WriteLine("\n3. O que Darth Vader revelou para Luke no episódio V da saga Star Wars?");
Console.WriteLine("a. Eu sou o seu pai!");
Console.WriteLine("b. Luke, eu sou o seu pai!");
Console.WriteLine("c. Luke, você é meu filho!");
Console.WriteLine("d. Não, eu sou o seu pai!");
Console.WriteLine("e. O Obi-Wan é o seu pai!");

Console.Write("\nDigite sua resposta: ");
resposta = char.Parse(Console.ReadLine()!);

CertoOuErrado(questao, resposta);

void CertoOuErrado(int questao, char resposta)
{
    if (respostas[questao].Equals(resposta))
    {
        Console.WriteLine("Parabéns, você acertou!");

    }
    else
    {
        Console.WriteLine("Você errou...");
    }
}

Thread.Sleep(3000);
Console.Clear();

//Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

Console.WriteLine("""
        
    ░░██╗██╗░░░
    ░██╔╝██║░░░
    ██╔╝░██║░░░
    ███████║░░░
    ╚════██║██╗
    ░░░░░╚═╝╚═╝
    """);

Dictionary<string, string> usuarios = new Dictionary<string, string>();

usuarios.Add("maria", "maria123#");
usuarios.Add("zezin", "zezin123#");

Console.WriteLine("\n********* LOGIN ********\n");
Console.Write("Nome de usuário: ");
string nome = Console.ReadLine()!;

Console.Write("Senha: ");
string senha = Console.ReadLine()!;

if (usuarios.ContainsKey(nome) && usuarios[nome].Equals(senha))
{
    Console.WriteLine("\nVocê está logado!");

}else
{
    Console.WriteLine("\nUsuário e/ou senha incorreto(s)");
}

Thread.Sleep(3000);

Console.WriteLine(@"

▄▀█ ▀█▀ █ █░█ █ █▀▄ ▄▀█ █▀▄ █▀▀   ▄█
█▀█ ░█░ █ ▀▄▀ █ █▄▀ █▀█ █▄▀ ██▄   ░█
");

Console.Write("Informe o valor da média: ");
int notaMedia = int.Parse(Console.ReadLine()!);//Criar uma variável chamada notaMedia e atribua um valor inteiro a ela.

if (notaMedia >= 5) //Caso seu valor seja maior ou igual a 5, 
{
    Console.WriteLine("Nota suficiente para aprovação"); //escreva na tela "Nota suficiente para aprovação".
}

Console.WriteLine(@"

▄▀█ ▀█▀ █ █░█ █ █▀▄ ▄▀█ █▀▄ █▀▀   ▀█
█▀█ ░█░ █ ▀▄▀ █ █▄▀ █▀█ █▄▀ ██▄   █▄
");

string[] linguagens = { "C#", "Java", "JavaScript" }; //Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
Console.WriteLine(linguagens[0]);//Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.

void EscolherUmaLinguagem(int n, string[] linguagens)
{
    Console.WriteLine();

    switch(n)
    { 
        case 1:
            Console.WriteLine($"Linguagem correspondente na lista: {linguagens[n - 1]}");
            break;

        case 2:
            Console.WriteLine($"Linguagem correspondente na lista: {linguagens[n - 1]}");
            break;

        case 3:
            Console.WriteLine($"Linguagem correspondente na lista: {linguagens[n - 1]}");
            break;

        default:
            Console.WriteLine("Linguagem não encontrada");
            break;
    }
}

Console.WriteLine(@"

▄▀█ ▀█▀ █ █░█ █ █▀▄ ▄▀█ █▀▄ █▀▀   █░█
█▀█ ░█░ █ ▀▄▀ █ █▄▀ █▀█ █▄▀ ██▄   ▀▀█
");

Console.Write("Lista de linguagens: ");
for(int i = 0; i < linguagens.Length; i++)
{
    if(i < 2)
    {
        Console.Write(linguagens[i] + ", ");
    }else
    {
        Console.Write(linguagens[i]);
    }
}

Console.Write("\nDigite um número de 1 a 3: ");
int n = int.Parse(Console.ReadLine()!);//Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado

EscolherUmaLinguagem(n, linguagens);//exibir a n-ésima posição de uma lista
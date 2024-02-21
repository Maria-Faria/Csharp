/*Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o 
 * resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando 
 * interpolação de strings.*/
Console.WriteLine("""
█▀▀ ▀▄▀ █▀▀ █▀█ █▀▀ █ █▀▀ █ █▀█   ▄█
██▄ █░█ ██▄ █▀▄ █▄▄ █ █▄▄ █ █▄█   ░█
""");

double a, b;

Console.Write("\nDigite um número: ");
a = Double.Parse(Console.ReadLine()!);

Console.Write("\nDigite outro número: ");
b = Double.Parse(Console.ReadLine()!);

Console.WriteLine("----------------------------");
Operacoes(a, b);
void Operacoes(double a, double b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
    Console.WriteLine($"{a} - {b} = {a - b}");
    Console.WriteLine($"{a} x {b} = {a * b}");
    Console.WriteLine($"{a} / {b} = {a/b}");
}

Thread.Sleep(3000);
Console.Clear();

/*Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.*/
Console.WriteLine("""
        
    █▀▀ ▀▄▀ █▀▀ █▀█ █▀▀ █ █▀▀ █ █▀█   ▀█
    ██▄ █░█ ██▄ █▀▄ █▄▄ █ █▄▄ █ █▄█   █▄
""");

List<string> bandas = new List<string>();

bandas.Add("The Beatles");
bandas.Add("Skank");
bandas.Add("Queen");
bandas.Add("NX Zero");

Console.WriteLine("\nMinhas bandas preferidas:\n");
/*foreach(string banda in bandas)
{
    Console.WriteLine($"{banda}");
}*/

/*Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista 
 * do exercício anterior, no console.*/
for (int i = 0; i < bandas.Count; i++)
{
    Console.WriteLine(bandas[i]);
}

Thread.Sleep(3000);
Console.Clear();

/*Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.*/
Console.WriteLine("""
        
    █▀▀ ▀▄▀ █▀▀ █▀█ █▀▀ █ █▀▀ █ █▀█  
    ██▄ █░█ ██▄ █▀▄ █▄▄ █ █▄▄ █ █▄█ 
""");

List<int> numeros = new List<int>() {5, 6, 8, 10, 25};
int soma = 0;

Console.Write("\nSoma de ");
for(int i = 0; i < numeros.Count; i++)
{
    if(i != numeros.Count - 1)
    {
        Console.Write($"{numeros[i]} + ");
    
    }else
    {
        Console.Write($"{numeros[i]} = ");
    }

    soma += numeros[i];
}

Console.WriteLine(soma);
/*Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.*/
class Conta
{
    public int Numero { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public string Senha { get; set; }

    public void ExibeDados()
    {
        Console.WriteLine($"Número da conta: {Numero}");
        Console.WriteLine($"Titular da conta: {Titular}");
        Console.WriteLine($"Saldo disponível: R${Saldo}");
    }
}
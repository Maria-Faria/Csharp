class Conta
{
    public Titular titular { get; set; }

    public string Agencia { get; set; }
    public int Numero { get; set; }
    public double Saldo { get; set; }
    public  double Limite { get; set; }

    public void informacoes()
    {
        Console.WriteLine($"Número da conta: {Numero}");
        Console.WriteLine($"Titular: {titular.Name}");
        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Saldo: R${Saldo}");
        Console.WriteLine($"Limite: R${Limite}");
    }
}
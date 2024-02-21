class Carro
{
    public string modelo;
    public string cor;
    public int ano;
   
    public void Acelerar()
    {
        Console.WriteLine("O carro está acelerando...");
    }

    public void Frear()
    {
        Console.WriteLine("O carro está freando...");
    }

    public void Buzinar()
    {
        Console.WriteLine("Bi bi bi");
    }

    public void ExibirFicha()
    {
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Cor: {cor}");
        Console.WriteLine($"Ano: {ano}");
    }
}
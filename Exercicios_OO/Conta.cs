/*Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.*/
class Conta
{
    public int numero;
    public string titular;
    public double saldo;
    public string senha;

    public void ExibeDados()
    {
        Console.WriteLine($"Número da conta: {numero}");
        Console.WriteLine($"Titular da conta: {titular}");
        Console.WriteLine($"Saldo disponível: R${saldo}");
    }
}
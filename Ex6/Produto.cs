/*Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. 
 * Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade 
 * que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.*/

using System.Reflection.Metadata.Ecma335;

class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    private double preco;
    private int estoque;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value > 0)
            {
                preco = value;

            } else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
    }

    public int Estoque
    {
        get { return estoque; }
        set
        {
            if (value > 0)
            {
                estoque = value;

            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }
    }

    public string Detalhes =>
        $"""
        Produto: {Nome}
        Marca: {Marca}
        Preço: {Preco}
        Estoque: {Estoque}
        """; 
}
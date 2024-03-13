/*Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie 
 * DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.*/

class Carro { 
    public string Fabricante {  get; set; }
    public string Modelo { get; set; }
    public string Cor {  get; set; }

    //Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
    private int _ano;
    public int Ano { 
        get { return _ano; }

        set
        {
            if (value >= 1960 && value <= 2023)
            {
                _ano = value;
            
            }
        }

    }
    public string DescricaoDetalhada { 
        get
        {
            return $"""
                Fabricante: {Fabricante}
                Modelo: {Modelo}
                Cor: {Cor}
                Ano: {Ano}
                """;
        }
    }
}

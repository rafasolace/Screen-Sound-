class Musica //Essa classe serve para definir "dados e atributos" presentes nas variaveis Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida
    //Versão LAMBDA resumida = public string DescricaoResumida => return $"A música {Nome} pertence à arista {Artista}"; 
    {
        get
        {
            return $"A música {Nome} pertence à arista {Artista}"; 
        } 
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Artista: {Artista}"); //Esse void é o "método" 
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}
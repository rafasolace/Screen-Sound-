class Musica //Essa classe serve para definir "dados e atributos" presentes nas variaveis Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool Disponivel { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome:{nome}");
        Console.WriteLine($"Artista: {artista}"); //Esse void é o "método" 
        Console.WriteLine($"Duração: {duracao}");
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
Banda arianagrande = new Banda("Ariana Grande");

Album albumDaArianaGrande = new Album("Eternal Sunshine");

Musica musica1 = new Musica(arianagrande, "intro (end of the word)")
{
    Duracao = 132,
    Disponivel = true,
};


Musica musica2 = new Musica(arianagrande, "the boy is mine")
{
    Duracao = 253,
    Disponivel = false,
};
musica2.Duracao = 253;

albumDaArianaGrande.AdicionarMusica(musica1);
albumDaArianaGrande.AdicionarMusica(musica2);
arianagrande.AdicionarAlbum(albumDaArianaGrande);
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDaArianaGrande.ExibirMusicaDoAlbum();
arianagrande.ExibirDicografia();
Album albumDaArianaGrande = new Album();
albumDaArianaGrande.Nome = "Eternal Sunshine";

Musica musica1 = new Musica();
musica1.Nome = "intro (end of the word)";
musica1.Duracao = 132;

Musica musica2 = new Musica();
musica2.Nome = "the boy is mine";
musica2.Duracao = 253;

albumDaArianaGrande.AdicionarMusica(musica1);
albumDaArianaGrande.AdicionarMusica(musica2);

albumDaArianaGrande.ExibirMusicaDoAlbum();
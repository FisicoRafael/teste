Biblioteca biblioteca = new Biblioteca();

Livro livro1 = new Livro(autorNome: "Autor 1", tituloLivro: "Tiulo 1");
biblioteca.adicionarLivro(livro1);

Livro livro2 = new Livro(autorNome: "Autor 2", tituloLivro: "Tiulo 2");
biblioteca.adicionarLivro(livro2);

Livro livro3 = new Livro(autorNome: "Autor 3", tituloLivro: "Tiulo 3");
biblioteca.adicionarLivro(livro3);


biblioteca.mostrasLivros();

Console.WriteLine("\n");

biblioteca.removerLivro(livro1);

biblioteca.mostrasLivros();
class Biblioteca
{
    private List<Livro> listaDeLivros = new List<Livro>();

    public void adicionarLivro(Livro livro)
    {
        listaDeLivros.Add(livro);
    }

    public void removerLivro(Livro livro)
    {
        listaDeLivros.Remove(livro);
    }

    public void mostrasLivros()
    {
        foreach (var item in listaDeLivros.Select((value, index) => new { index, value }))
        {
            Console.WriteLine($"Livro {item.index+1}, titulo: {item.value.getTitulo()}, autor: {item.value.getAutor()}");
        }
    }

}
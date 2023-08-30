using System.Dynamic;

class Livro
{
    private String autorNome;
    private String tituloLivro;

    public Livro(String autorNome, String tituloLivro)
    {
        this.autorNome = autorNome;
        this.tituloLivro = tituloLivro;
    }

    public String getAutor(){
        return autorNome;
    }

     public String getTitulo(){
        return tituloLivro;
    }
}
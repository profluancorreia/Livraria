using aula_13_de_março;
using Xunit;

namespace Teste
{
    public class UnitTest1
    {
        [Fact]
        public void Correto()
        {
            Livro livro = new Livro();
            livro.titulo = "A montanha encantada";
            livro.autor = "Robbin Willians";
            livro.editora = "Beto Carrero";
            livro.anoedicao = "2000";
            livro.local = "São Vicelva";
            LivroBLL.ValidaLivro(livro);
            Assert.False(Erro.getErro());


        }
        [Theory]
        [InlineData("")]
        [InlineData("titulo")]
        public void TesteTitulo(String titulo)
        {
            Livro livro = new Livro();
            livro.titulo = titulo;
            livro.autor = "Robbin Willians";
            livro.editora = "Beto Carrero";
            livro.anoedicao = "2000";
            livro.local = "São Vicelva";
            LivroBLL.ValidaLivro(livro);
            Assert.False(Erro.getErro());


        }
        [Theory]
        [InlineData("")]
        [InlineData("autor")]
        public void TesteAutor(String autor)
        {
            Livro livro = new Livro();
            livro.titulo = "A montanha encantada";
            livro.autor = autor;
            livro.editora = "Beto Carrero";
            livro.anoedicao = "2000";
            livro.local = "São Vicelva";
            LivroBLL.ValidaLivro(livro);
            Assert.False(Erro.getErro());


        }
        [Theory]
        [InlineData("")]
        [InlineData("editora")]
        public void TesteEditora(String editora)
        {
            Livro livro = new Livro();
            livro.titulo = "A montanha encantada";
            livro.autor = "Robbin Willians";
            livro.editora = editora;
            livro.anoedicao = "2000";
            livro.local = "São Vicelva";
            LivroBLL.ValidaLivro(livro);
            Assert.False(Erro.getErro());


        }
        [Theory]
        [InlineData("")]
        [InlineData("2000")]
        [InlineData("Abacaxi")]
        public void TesteAnoEdicao(String anoEdicao)
        {
            Livro livro = new Livro();
            livro.titulo = "A montanha encantada";
            livro.autor = "Robbin Willians";
            livro.editora = "Beto Carrero";
            livro.anoedicao = anoEdicao;
            livro.local = "São Vicelva";
            LivroBLL.ValidaLivro(livro);
            Assert.False(Erro.getErro());


        }
        [Theory]
        [InlineData("")]
        [InlineData("local")]
        public void TesteLocal(String local)
        {
            Livro livro = new Livro();
            livro.titulo = "A montanha encantada";
            livro.autor = "Robbin Willians";
            livro.editora = "Beto Carrero";
            livro.anoedicao = "2000";
            livro.local = local;
            LivroBLL.ValidaLivro(livro);
            Assert.False(Erro.getErro());


        }
    }
}
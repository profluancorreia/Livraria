using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_13_de_março
{
    public class LivroBLL
    {
        public static void ValidaLivro(Livro livro)
        {
            Erro.setErro(false);
            if (livro.titulo.Length == 0 || livro.autor.Length == 0 || livro.editora.Length == 0 || livro.anoedicao.Length == 0 || livro.local.Length == 0)
            {
                Erro.setErro("Nenhuma caixa pode estar vazia! Insira um dado!");
                return;
            }

            else
            {
                try
                {
                    int.Parse(livro.anoedicao);
                }
                catch
                {
                    Erro.setErro("O campo TEM que ser numerico e TEM que ser Inteiro");
                    return;
                }
                if (int.Parse(livro.anoedicao) <= 0)
                {
                    Erro.setErro("O livro tem que ser de um ano maior que zero");
                    return;
                }
            }

        }
    }
}
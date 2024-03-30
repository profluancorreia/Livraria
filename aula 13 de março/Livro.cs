using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_13_de_março
{
    public class Livro
    {
        public string titulo;
        public string autor;
        public string editora;
        public string anoedicao;
        public string local;

        String Nome
        {
            get { return titulo; }
            set { titulo = value; }
        }
        String Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        String Editora
        {
            get { return editora; }
            set { editora = value; }
        }
        String AnoEdicao
        {
            get { return anoedicao; }
            set { anoedicao = value; }
        }
        String Local
        {
            get { return local; }
            set { local = value; }
        }

        public String getTitulo() { return titulo; }
        public String getAutor() { return autor; }
        public String getEditora() { return editora; }
        
        public String getAnoedicao() { return anoedicao; }

        public String getLocal() { return local; }

    }
}

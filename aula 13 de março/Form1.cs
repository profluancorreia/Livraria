using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_13_de_março
{
    public partial class Form1 : Form
    {
        Livro livro = new Livro();
        bool erro01aconteceu = false;
        bool erro01veredito = false;
        bool erro02veredito = false;
        bool erro03veredito = false;
        public Form1()
        {
            InitializeComponent();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            

            livro.titulo = textBox1.Text;
            livro.autor = textBox2.Text;
            livro.editora = textBox3.Text;
            livro.anoedicao = textBox4.Text;
            livro.local = textBox5.Text;

            LivroBLL.ValidaLivro(livro); //faz a validacao
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro01aconteceu = true;
            }
            else
            {
                MessageBox.Show("Seus dados foram salvos com sucesso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            
            MessageBox.Show("titulo: " + livro.getTitulo() + " autor: " + livro.getAutor() + " editora: " + livro.getEditora() + " ano da edicao: " + livro.getAnoedicao() + " local: " + livro.getLocal());
        }
    } 
}

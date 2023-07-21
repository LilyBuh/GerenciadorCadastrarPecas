using GerenciadorCadastrarPecas.Controller;
using GerenciadorCadastrarPecas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorCadastrarPecas.View
{
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }

        private void Alterar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtcodigopeca.Text);

            ManipulaPecas manipulaPecas = new ManipulaPecas();
            manipulaPecas.BuscaPecasCod();

            txtcodigo.Text = Pecas.Codigo.ToString();
            txtpeca.Text = Pecas.Peca;
            txtmarca.Text = Pecas.Marca;
            txtcapacidade.Text = Pecas.Capaciade;

           
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtcodigopeca.Text);
            Pecas.Peca = txtpeca.Text;
            Pecas.Marca = txtmarca.Text;
            Pecas.Capaciade = txtcapacidade.Text;

            ManipulaPecas mpecas = new ManipulaPecas();
            mpecas.AlterarPeca();
        }
    }
}

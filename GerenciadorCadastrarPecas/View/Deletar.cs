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
    public partial class Deletar : Form
    {
        public Deletar()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            Pecas.Codigo = Convert.ToInt32(txtcodigopeca.Text);

            ManipulaPecas manipulaPecas = new ManipulaPecas();
            manipulaPecas.BuscaPecasCod();

            txtcodigo.Text = Pecas.Codigo.ToString();
            txtpeca.Text = Pecas.Peca;
            txtmarca.Text = Pecas.Marca;
            txtcapacidade.Text = Pecas.Capaciade;

        }

        public void AbrirDeletar()
        {
            this.ShowDialog();
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txtcodigo.Text);

            ManipulaPecas manipulaPecas = new ManipulaPecas();
            manipulaPecas.DeletarPecas();
        }
    }
}

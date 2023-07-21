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
    public partial class ViewPecas : Form
    {
        public ViewPecas()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Pecas.Peca = txtpeca.Text;
            Pecas.Marca = txtmarca.Text;
            Pecas.Capaciade = txtcapacidade.Text;

            ManipulaPecas mPecas = new ManipulaPecas();
            mPecas.CadPecas();
        }
        public void AbrirCadastro()
        {
            this.ShowDialog();
        }
    }
}

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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPecas viewpecas= new ViewPecas();
            viewpecas.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar alterar= new Alterar();
            alterar.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deletar deletar= new Deletar();
            deletar.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPecas buscar= new BuscarPecas();
            buscar.Show();
        }
    }
}

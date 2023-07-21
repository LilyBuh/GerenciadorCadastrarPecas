using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCadastrarPecas.Model
{
    internal class conexao
    {

        public  static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bruno.vscorreia\source\repos\GerenciadorCadastrarPecas\GerenciadorCadastrarPecas\Model\BancoDeDados.mdf;Integrated Security=True";
        }
    }
}

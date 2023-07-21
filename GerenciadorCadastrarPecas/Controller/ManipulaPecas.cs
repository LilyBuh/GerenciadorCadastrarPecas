using GerenciadorCadastrarPecas.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using GerenciadorCadastrarPecas.View;
using System.Security.Cryptography;

namespace GerenciadorCadastrarPecas.Controller
{
    internal class ManipulaPecas
    {
        public void CadPecas() 
        {

            SqlConnection cn =  new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pcadastrarPecas" , cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("Marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("Capacidades", Pecas.Capaciade);

                SqlParameter nv =  cmd.Parameters.Add("idpecas", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça Cadastrada com sucesso.",
                    " Deseja cadastrar novamente?", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                if (resposta== DialogResult.Yes)
                {
                    ViewPecas cadastro = new ViewPecas();
                    cadastro.AbrirCadastro();
                }
                else
                {
                    return;

                }
            
            
            }
            catch (Exception)
            {

                throw;
            }

        }


        public void BuscaPecasCod()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscaPecasCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cn.Open();

                var registros = cmd.ExecuteReader();

                if (registros.Read())
                {
                    Pecas.Codigo = Convert.ToInt32(registros["idPecas"]);
                    Pecas.Marca =     (string)registros["Marcas"];
                    Pecas.Peca =      (string)registros["Pecas"];
                    Pecas.Capaciade = (string)registros["Capacidades"];
                }

                else
                {
                    Pecas.Codigo = 0;
                    Pecas.Peca = "";
                    Pecas.Marca = "";
                    Pecas.Capaciade = "";
                    MessageBox.Show("Peça não encontrada", "Pesquisar Código");




                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void DeletarPecas()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Deseja Deletar novamente", "Peça deleta com sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Deletar del = new Deletar();
                    del.AbrirDeletar();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }


        public void AlterarPeca()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cmd.Parameters.AddWithValue("Pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("Marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("Capacidade", Pecas.Capaciade);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Peça Alterada com suesso.");
                Pecas.Codigo = 0;
                Pecas.Peca = "";
                Pecas.Marca = "";
                Pecas.Capaciade = "";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}



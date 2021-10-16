using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Salvar(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=2021_02;SSLMode=none;");
            string comandoSQL = "INSERT INTO aluno (nome) VALUES('" + txtNome.Text + "')";
            MySqlCommand comando = new MySqlCommand(comandoSQL,conexao);
            
            conexao.Open();
            comando.ExecuteNonQuery();

            MessageBox.Show("DADOS SALVOS");

            comando.Dispose();
            conexao.Close();
        }

        private void Deletar(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=2021_02;SSLMode=none;");
            string comandoSQL = "DELETE FROM aluno WHERE matricula="+ txtMatricula.Text;
            MySqlCommand comando = new MySqlCommand(comandoSQL, conexao);

            conexao.Open();
            comando.ExecuteNonQuery();

            MessageBox.Show("DADOS DELETADOS");

            comando.Dispose();
            conexao.Close();
        }

        private void Atualizar(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=2021_02;SSLMode=none;");
            string comandoSQL = "UPDATE aluno SET nome='" + txtNome.Text + "' WHERE matricula='" + txtMatricula.Text+"'";
            MySqlCommand comando = new MySqlCommand(comandoSQL,conexao);
            
            conexao.Open();
            comando.ExecuteNonQuery();

            MessageBox.Show("DADOS ATUALIZADOS");

            comando.Dispose();
            conexao.Close();
        }
    }
}

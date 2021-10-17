using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace CRUD
{
    public partial class Form1 : Form
    {
        MySqlDataReader dr;
        MySqlDataAdapter da;

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=2021_02;SSLMode=none;");
            string comandoSQL = "SELECT * FROM aluno WHERE matricula=" + txtMatricula.Text;
            MySqlCommand comando = new MySqlCommand(comandoSQL, conexao);

            conexao.Open();
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                txtNome.Text = Convert.ToString(dr["nome"]);
            }

            MessageBox.Show("DADOS SELECIONADOS");

            comando.Dispose();
            conexao.Close();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=2021_02;SSLMode=none;");
            string comandoSQL = "SELECT nome,matricula FROM aluno";

            da = new MySqlDataAdapter(comandoSQL, conexao);

            DataTable dataTable = new DataTable();

            da.Fill(dataTable);

            dataGridView1.DataSource = dataTable;


            MessageBox.Show("DADOS SELECIONADOS");

            conexao.Close();
        }
    }
}

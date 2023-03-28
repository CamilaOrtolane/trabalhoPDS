using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppContatoForm
{
    public partial class ListarContatos : Form
    {
        private MySqlConnection conexao;

        private MySqlCommand comando;


        public ListarContatos()
        {
            InitializeComponent();
            Conexao();

            //listContato.Columns.Add("ID", 30, HorizontalAlignment.Left);
            //listContato.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            //listContato.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            //listContato.Columns.Add("Sexo", 150, HorizontalAlignment.Left);
            //listContato.Columns.Add("Data De Nascimento", 150, HorizontalAlignment.Left);
            //listContato.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            CarregarDados();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }

        private void CarregarDados()
        {
            try
            {
                string l = "%" + txtBusca.Text + "%";

                //string sql = "SELECT * FROM contato WHERE nome_con LIKE %" + txtBusca + "%";
                string sql = "SELECT * FROM contato";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                var adapter = new MySqlDataAdapter(comando);

                DataTable tabela = new DataTable();

                adapter.Fill(tabela);

                tabela.Columns["id_con"].ColumnName = "ID";
                tabela.Columns["nome_con"].ColumnName = "Nome";
                tabela.Columns["data_nasc_con"].ColumnName = "Data de Nascimento";
                tabela.Columns["sexo_con"].ColumnName = "Sexo";
                tabela.Columns["email_con"].ColumnName = "Email";
                tabela.Columns["telefone_con"].ColumnName = "Telefone";


                dgvContato.DataSource = tabela;


                //MySqlDataReader reader = comando.ExecuteReader();

                //listContato.Clear();

                //while (reader.Read())
                //{
                //    string[] row =
                //    {
                //        reader.GetString(0),
                //        reader.GetString(1),
                //        reader.GetString(2),
                //        reader.GetString(3),
                //        reader.GetString(4),
                //        reader.GetString(5),

                //    };

                //    var linhaListview = new ListViewItem(row);
                //    listContato.Items.Add(linhaListview);
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            string l =txtBusca.Text;

            string sql = "SELECT * FROM contato WHERE nome_con LIKE '" + l + "%'";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            var adapter = new MySqlDataAdapter(comando);

            DataTable tabela = new DataTable();

            adapter.Fill(tabela);
            dgvContato.DataSource = tabela;
            tabela.Columns["id_con"].ColumnName = "ID";
            tabela.Columns["nome_con"].ColumnName = "Nome";
            tabela.Columns["data_nasc_con"].ColumnName = "Data de Nascimento";
            tabela.Columns["sexo_con"].ColumnName = "Sexo";
            tabela.Columns["email_con"].ColumnName = "Email";
            tabela.Columns["telefone_con"].ColumnName = "Telefone";


            
        }
    }
}

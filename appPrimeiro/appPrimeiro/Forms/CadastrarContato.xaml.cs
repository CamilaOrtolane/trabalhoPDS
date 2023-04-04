using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace appPrimeiro
{
    /// <summary>
    /// Lógica interna para CadastrarContato.xaml
    /// </summary>
    public partial class CadastrarContato : Window
    {

        public bool Checked { get; set; }

        private MySqlConnection conexao;

        private MySqlCommand comando;

        public CadastrarContato()
        {
            InitializeComponent();
            Conexao();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool sexo1 = Convert.ToBoolean(rdSexo1.IsChecked);
            bool sexo2 = Convert.ToBoolean(rdSexo2.IsChecked);
            try
            {
                if (txtNome.Text == string.Empty || txtEmail.Text == string.Empty || txtTelefone.Text == string.Empty)
                {
                    MessageBox.Show("Adicione as informaçções ao campo");
                }
                else
                {
                    if (!sexo1 && !sexo2)
                    {
                        MessageBox.Show("Marque uma opção");

                    }

                    else
                    {
                        var nome = txtNome.Text;
                        var email = txtEmail.Text;
                        var dataNasc = dateDataNascimento.Text;
                        var fone = txtTelefone.Text;
                        var sexo = "Feminino";

                        if (sexo1)
                        {
                            sexo = "Masculino";
                        }

                        string query = "INSERT INTO Contato (nome_con, data_nasc_con, email_con, sexo_con, telefone_con) VALUES (@_nome, @_dataNasc, @_email, @_sexo, @_fone)";
                        var comando = new MySqlCommand(query, conexao);


                        comando.Parameters.AddWithValue("@_nome", nome);
                        comando.Parameters.AddWithValue("@_email", email);
                        comando.Parameters.AddWithValue("@_sexo", sexo);
                        comando.Parameters.AddWithValue("@_dataNasc", dataNasc);
                        comando.Parameters.AddWithValue("@_fone", fone);


                        comando.ExecuteNonQuery();

                        MessageBox.Show($"Dados salvos com sucesso!");
                        txtEmail.Clear();
                        txtTelefone.Clear();
                        txtNome.Clear();
                        this.Close();
                    }
                }




            }
            catch (Exception ex)
            {
                /*MessageBox.Show($"Ocorreun um erro ao tentar salvar os dados!" +
                    $"Contate o suporte do sistema. (CAD 25)");*/

                MessageBox.Show(ex.Message);
            }

        }
    }
}

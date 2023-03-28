using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica interna para ListarContato.xaml
    /// </summary>
    public partial class ListarContato : Window
    {
        private MySqlConnection conexao;

        private MySqlCommand comando;

        public ListarContato()
        {
            InitializeComponent();
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
            
                Conexao();
                string query = "SELECT * FROM contato";
                var comando = new MySqlCommand(query, conexao);

                 var reader = comando.ExecuteReader();

                List<object> dados = new List<object>();
                while (reader.Read())
                {
                    var contato = new
                    {
                        Nome = reader.GetString(1),
                    };

                    dados.Add(contato);
                }

                dgvContato.ItemsSource = dados;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        

        private void dgvContato_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            


        }
    }
}

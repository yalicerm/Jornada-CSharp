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
using WpfAgendaUsandoBD.BD;
using MySql.Data.MySqlClient;

namespace WpfAgendaUsandoBD
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            CarregarDados();

        }

        private void CarregarDados()
        {
             // Instancia nossa classe de conexão
            ConexaoBD bd = new ConexaoBD();

            // Criando nossa querry SELECT para trazer todos os dados da tabela contatos
            string comandoSQL = "SELECT * FROM contatos";

            try
            {
                using (MySqlConnection conexao = bd.ObterConexao())
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(comandoSQL, conexao))
                    {
                        // Vamos usar o DataAdapter que vai até o banco, roda a query e traz os dados
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            // Cria uma tabela vazia na memória
                            DataTable tabelaAgenda = new DataTable();

                            // Preenche essa tabela com os dados trazidos pelo adaptador
                            adaptador.Fill(tabelaAgenda);

                            // Pega a tabela cheia e entrega para o DataGrid mostrar na tela
                            dgAgenda.ItemsSource = tabelaAgenda.DefaultView;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a agenda completa: " + ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void buttonVoltar_Click(object sender, RoutedEventArgs e)
        {
            //Voltando para página inical
            this.Close();

        }
    }
}

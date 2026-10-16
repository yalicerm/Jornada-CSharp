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
using System.Windows.Navigation;
using System.Windows.Shapes;

using MySql.Data.MySqlClient;
using WpfAgendaUsandoBD.BD;

namespace WpfAgendaUsandoBD
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, RoutedEventArgs e)
        {
            ConexaoBD bd = new ConexaoBD();
            string comandosSQL = "INSERT INTO contatos (nome, telefone, email) VALUES (@nome, @telefone, @email)";

            try
            {
                //Usando o bloco using para garantir que a conexão seja fechada corretamente após o uso
                using (MySqlConnection conexao = bd.ObterConexao())
                {
                    
                    // Chamando o MySqlComando para executar o comando SQL e sinalizando qual conexão será usada
                    using (MySqlCommand comando = new MySqlCommand(comandosSQL, conexao))
                    {
                        //Abrir o banco de dados
                        conexao.Open();

                        //Usando os parametros para evitar SQL Injection e adicionando os valores dos campos de texto
                        comando.Parameters.AddWithValue("@nome", textNome.Text);
                        comando.Parameters.AddWithValue("@telefone", textTel.Text);
                        comando.Parameters.AddWithValue("@email", textEmail.Text);

                        // Chamando o comando ExecuteNonQuery que é usado para INSERT, UPDATE e DELETE nas tabelas
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao salvar os dados: " + ex.Message);
            }
        }

        private void buttonVisualizar_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void buttonBuscar_Click(object sender, RoutedEventArgs e)
        {
            ConexaoBD bd = new ConexaoBD();
            string busca = "%" + textBusca.Text + "%"; //Uso da porcetagem mostra que ele é o nosso Like la no text de busca
            string resultadoSQL = "SELECT * FROM contatos WHERE telefone LIKE @busca";
            try
            {
                using (MySqlConnection conexao = bd.ObterConexao())
                {

                    // Chamando o MySqlComando para executar o comando SQL e sinalizando qual conexão será usada
                    using (MySqlCommand comando = new MySqlCommand(resultadoSQL, conexao))
                    {
                        //Abrir o banco de dados
                        conexao.Open();

                        //Avisar o comando que o parametro @busca será usado e qual valor ele terá
                        comando.Parameters.AddWithValue("@busca", busca);

                        using (MySqlDataReader leitor = comando.ExecuteReader())
                        {
                            // Processar os resultados
                        }

                        ///MessageBox.Show("Contato achado!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Contato não encontrado: " + ex.Message);
            }
        }
    }
}

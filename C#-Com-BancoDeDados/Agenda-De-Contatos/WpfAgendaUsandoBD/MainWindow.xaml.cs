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
            //Verifica se os campos de texto estão vazios antes de tentar salvar os dados no banco de dados
            if (string.IsNullOrWhiteSpace(textNome.Text) || string.IsNullOrWhiteSpace(textTel.Text) || string.IsNullOrWhiteSpace(textEmail.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de salvar.", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            };
            
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
           //Abre uma janela nova que contém um datagrid que exibe todos os contatos cadastrados no banco de dados, ou seja, exibe nossa Agenda de Contato inteira
           WindowResultado resultados = new WindowResultado();
           resultados.ShowDialog(); // Abre a janela de resultados 
        }

        private void buttonBuscar_Click(object sender, RoutedEventArgs e)
        {
            //Campos vazios
		 if (string.IsNullOrWhiteSpace(textBusca.Text))
		 {
	     MessageBox.Show("Por favor, insira um número de telefone para buscar.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
	     return; // Sai do método se o campo de busca estiver vazio
		 }
		 
        ConexaoBD bd = new ConexaoBD();
        string busca = "%" + textBusca.Text + "%"; //Uso da porcetagem mostra que ele é o nosso Like la no text de busca
        string resultadoSQL = "SELECT * FROM contatos WHERE telefone LIKE @busca";

        //Para mostrar os resultados da busca, vamos usar um ListView e para isso vamos criar uma lista de contatos que será preenchida com os resultados da busca
        List<object> contatosEncontrados = new List<object>(); //Uma lista de objeto generica/anonimo.

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
                        while (leitor.Read())
                        {
                            // Adicionar cada contato encontrado à lista
                            var dadosContato = new
                            {
                                Nome = leitor["nome"].ToString(),
                                Telefone = leitor["telefone"].ToString(),
                                Email = leitor["email"].ToString()
                            };
                        contatosEncontrados.Add(dadosContato);
                    }
                }
            }
        }

        textBusca.Clear();
        textBusca.Focus();

        //Fazer a verificação caso a lista estiver vazia, ou seja, não encontrou nenhum contato com o telefone informado
        if (contatosEncontrados.Count > 0)
        {
            //Pega o nome atribuido a ListView no XAMP e usa o comando ItemSource para atribuir a lista de contatos encontrados ao ListView
            listaBusca.ItemsSource = contatosEncontrados; 
            MessageBox.Show("Contato(s) encontrado(s)!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
        } 
        else
        {
            listaBusca.ItemsSource = null; //Limpa a lista caso não encontre nenhum contato
            MessageBox.Show("Nenhum contato encontrado com este número.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Contato não encontrado: " + ex.Message);
            }
        }
    }
}

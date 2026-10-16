using CofrinhoCode.Control; //Ligando o Controller com o View

namespace CofrinhoCode
{
    public partial class Form1 : Form
    {
        //Variáveis para auxiliar o Controller
        public string NomeMoeda { get => textboxNome.Text; }
        public string ValorMoeda { get => textBoxValor.Text; }

        //Eventos para auxiliar o Controller
        public event EventHandler AdicionarClicked;
        public event EventHandler CalcularTotalClicked;
        public event EventHandler OutrosClicked;
        public Form1()
        {
            InitializeComponent();

            //Ligando os cliques reais da tela aos nossos eventos
            butAdd.Click += (s, e) => AdicionarClicked?.Invoke(this, EventArgs.Empty);
            butCalcular.Click += (s, e) => CalcularTotalClicked?.Invoke(this, EventArgs.Empty);
            butOutros.Click += (s, e) => OutrosClicked?.Invoke(this, EventArgs.Empty);
        }

        //Método para o Controller exibir na tela
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        //Limpar a tela e voltar o curso para o campo de nome
        public void LimparCampos()
        {
            textboxNome.Clear();
            textBoxValor.Clear();
            textboxNome.Focus();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {

        }

        private void butOutros_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}

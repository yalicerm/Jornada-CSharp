using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using UVVkedin_forms.Model;

namespace UVVkedin_forms
{
    public partial class RedeAmigos : Form
    {
        public string Apelido { get => textApelido.Text; set => textApelido.Text = value; }
        public string Telefone { get => textTelefone.Text; set => textTelefone.Text = value; }
        public string Email { get => textEmail.Text; set => textEmail.Text = value; }

        //Eventos que avisa o Controller que uma ação foi solicitada pelo usuário.

        public event EventHandler CadastrarClicked;
        public event EventHandler BuscarClicked;
        public event EventHandler RemoverClicked;
        public event EventHandler ListarTodosClicked;


        public RedeAmigos()
        {
            InitializeComponent();

            buttonCadastrar.Click += (s, e) => CadastrarClicked?.Invoke(this, EventArgs.Empty);
            buttonBuscar.Click += (s, e) => BuscarClicked?.Invoke(this, EventArgs.Empty);
            buttonRemov.Click += (s, e) => RemoverClicked?.Invoke(this, EventArgs.Empty);
            buttonListar.Click += (s, e) => ListarTodosClicked?.Invoke(this, EventArgs.Empty);

           public void AtualizarListaAmigos(List<Amigo> amigos)
        {
            listAmigos.Items.Clear();
            foreach (var amg in amigos)
            {
                listAmigos.Items.Add(amg.ToString());
            }
        }

        public void ExibirMsg(string mensage)
        {
            MessageBox.Show(mensage, "Aviso do Sistema");
        }


        public void LimparCampos()
        {
            Apelido = "";
            Telefone = "";
            Email = "";
        }

    }
    }


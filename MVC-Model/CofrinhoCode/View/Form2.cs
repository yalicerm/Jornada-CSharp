using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CofrinhoCode.View
{
    public partial class Form2 : Form
    {
        //Facilitando a comunicação com o Controller
        public string filtroValor { get => textOutros.Text; }

        //Criando os botões de eventos para o Controller
        public event EventHandler ContarTodasClicked;
        public event EventHandler ContarPorValorClicked;
        public event EventHandler MaiorValorClicked;
        public Form2()
        {
            InitializeComponent();

            //Criando os botões que chama os eventos
            buttipoMoeda.Click += (s, e) => ContarPorValorClicked?.Invoke(this, EventArgs.Empty);
            butNumMoedas.Click += (s, e) => ContarTodasClicked?.Invoke(this, EventArgs.Empty);
            butMaior.Click += (s, e) => MaiorValorClicked?.Invoke(this, EventArgs.Empty);

        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
    }
}

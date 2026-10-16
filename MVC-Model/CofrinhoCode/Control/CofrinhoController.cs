using System;
using System.Collections.Generic;
using System.Text;
using CofrinhoCode.Model;
using CofrinhoCode.View;

namespace CofrinhoCode.Control
{
    public class CofrinhoController
    {
        //Atribuindo o model e a view para o controller
        private readonly Cofrinho _model;
        private readonly Form1 _view;

        public CofrinhoController(Cofrinho model, Form1 view)
        {
            _model = model;
            _view = view;

            //Ligando os eventos da tela aos métodos do controller
            _view.AdicionarClicked += OnAdicionar;
            _view.CalcularTotalClicked += OnCalcularTotal;
            _view.OutrosClicked += OnOutros;
        }

        private void OnAdicionar(object sender, EventArgs e)
        {
             //Validando se os campos estão vazios: 
             if (string.IsNullOrWhiteSpace(_view.NomeMoeda) || string.IsNullOrWhiteSpace(_view.ValorMoeda))
            {
                _view.ExibirMensagem("Por favor, preencha todos os campos.");
                return;
            }

            //Convertendo o texto para double e tratando possíveis erros de conversão:
            if (!double.TryParse(_view.ValorMoeda, out double valorConvertido))
            {
                _view.ExibirMensagem("Valor inválido. Por favor, insira um número válido.");
                return;
            }

            //Criando uma nova moeda se os dados tiverem passado pelas validações
                
             Moeda m = new Moeda(valorConvertido, _view.NomeMoeda);
            _model.adicionar(m);
            _view.ExibirMensagem($"Moeda {m.nome} de valor {m.valor} adicionada ao cofrinho.");
            _view.LimparCampos();
            
            
        }

        private void OnCalcularTotal(object sender, EventArgs e)
        {
            //Chama o método de calcular do model
            double total = _model.calcularTotal();
            _view.ExibirMensagem($"Valor depositado no cofrinho: {total}");
        }

        private void OnOutros(object sender, EventArgs e)
        {
            //Instancia a segunda tela que levo o usuário acessar os outros métodos
            Form2 telaOutros = new Form2();
            telaOutros.ShowDialog();
        }
    }
}

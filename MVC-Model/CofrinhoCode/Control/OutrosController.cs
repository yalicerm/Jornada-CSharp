using System;
using System.Collections.Generic;
using System.Text;
using CofrinhoCode.Model;
using CofrinhoCode.View;

namespace CofrinhoCode.Control
{
    internal class OutrosController
    {
        private readonly Cofrinho _model;
        private readonly Form2 _view;

        public OutrosController(Cofrinho model, Form2 view)
        {
            _model = model;
            _view = view;

            // Ligando os eventos da tela aos métodos do controller
            _view.ContarTodasClicked += OnContarTodas;
            _view.ContarPorValorClicked += OnContarPorValor;
            _view.MaiorValorClicked += OnMaiorValor;
        }

        private void OnContarTodas(object sender, EventArgs e)
        {
            int total = _model.totalMoedas();
            _view.ExibirMensagem($"Total de moedas no cofrinho: {total}");
        }

        private void OnContarPorValor(object sender, EventArgs e)
        {
            //Valida se o usuario digitou um número válido no label de busca por determinado valor
            if (!double.TryParse(_view.filtroValor, out double valorConvertido))
            {
                _view.ExibirMensagem("Valor inválido. Por favor, insira um número válido.");
                return;
            }

            //Chama o método de contar moedas de determinado valor do model e exibir a mensagem
            int quantidade = _model.totalValorMoeda(valorConvertido);
            _view.ExibirMensagem($"Total de moedas de valor {valorConvertido}: {quantidade}");
        }

        private void OnMaiorValor(object sender, EventArgs e)
        {
            //Buscar o objeto Moeda no model e exibir a mensagem com o nome e valor da moeda de maior valor

            Moeda maior = _model.maiorMoeda();
            if (maior != null)
            {
                _view.ExibirMensagem($"A moeda de maior valor é: {maior.nome} com valor de {maior.valor}");
            }
            else
            {
                _view.ExibirMensagem("Não há moedas no cofrinho.");
            }
        }

    }
}

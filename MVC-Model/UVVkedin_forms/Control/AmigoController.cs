using System;
using System.Collections.Generic;
using System.Text;
using UVVkedin_forms.Model;
using UVVkedin_forms.View;

namespace UVVkedin_forms.Control
{
    public class AmigoController
    {
        private readonly Form1 _view;
        private readonly AmigoRepository _repository;

        public AmigoController(Form1 view, AmigoRepository repository)
        {
            _view = view;
            _repository = repository;
            // Subscribe to view events
            _view.CadastrarClicked += OnCadastrarClicked;
            _view.BuscarClicked += OnBuscarClicked;
            _view.RemoverClicked += OnRemoverClicked;
            _view.ListarTodosClicked += OnListarTodosClicked;
        }

        private void OnCadastrar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.Apelido))
            {
                _view.ExibirMensagem("O Apelido é obrigatório para o cadastro!");
                return;
            }
        }

        var novoAmigo = new Amigo
        {
            Apelido = _view.Apelido,
            Telefone = _view.Telefone,
            Email = _view.Email
        };

        _repository.Cadastrar(novoAmigo);
            _view.ExibirMensagem("Amigo cadastrado com sucesso!");
            _view.LimparCampos();
            AtualizarGrid();

        private void OnBuscar(object sender, EventArgs e)
        {
            var amigo = _repository.BuscarPorApelido(_view.Apelido);
            if (amigo != null)
            {
                // Preenche os campos da tela com os dados encontrados
                _view.Telefone = amigo.Telefone;
                _view.Email = amigo.Email;
                _view.ExibirMensagem("Amigo encontrado!");
            }
            else
            {
                _view.ExibirMensagem("Amigo não encontrado na base de dados.");
            }
        }

        private void OnRemover(object sender, EventArgs e)
        {
            var amigo = _repository.BuscarPorApelido(_view.Apelido);
            if (amigo != null)
            {
                _repository.Remover(amigo);
                _view.ExibirMensagem("Amigo removido com sucesso!");
                _view.LimparCampos();
                AtualizarGrid();
            }
            else
            {
                _view.ExibirMensagem("Amigo não encontrado para remoção.");
            }
        }

        private void OnListarTodos(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            _view.AtualizarListaDeAmigos(_repository.ListarTodos());
        }
    }
}

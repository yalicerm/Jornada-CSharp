using System;
using System.Collections.Generic;
using System.Text;

namespace UVVkedin_forms.Model
{
    internal class RepositoryAmigo
    {
        //Seria nossa camada BD
        private List<Amigo> _tabeloAmigos = new List<Amigo>();


        public void Cadastrar(Amigo amigo)
        {
            _tabeloAmigos.Add(amigo);
        }

        public void Remover(Amigo amigo)
        {
            _tabeloAmigos.Remove(amigo);
        }


        public Amigo BuscarPorApelido(string apelido)
        {
            return _tabeloAmigos.FirstOrDefault(a => a.Apelido == apelido);
        }

        public List<Amigo> ListarTodos()
        {
            return _tabeloAmigos;

        }
    }

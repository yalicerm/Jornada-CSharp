using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Model
{
    public class Livraria
    {
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }

        List<Livro> livros;

        public Livraria (string razaoSocial, string cnpj)
        {
            this.razaoSocial = razaoSocial;
            this.cnpj = cnpj;
            livros = new List<Livro>();
        }

        public void adicionarLivros(Livro l)
        {
            livros.Add(l);
        }

        public Livro buscarLivro(string titulo)
        {
            foreach (Livro l in livros)
            {
                if (l.nomeLivro == titulo)
                {
                    //Caso usuário digitar o título com letras maiúsculas ou minúsculas, o programa ainda encontra o livro
                    if (livro.Titulo.Equals(tituloProcurado, StringComparison.OrdinalIgnoreCase))
                    {
                        return livro; // Devolve o objeto completo se encontrar
                    }

                    else
                    {
                        return null; // Devolve null se não encontrar
                    }
            }
            }

        }

        public bool Remover(string isbn)
        {
            foreach (Livro l in livros)
            {
                if (l.ISBN.ToString() == isbn)
                {
                    livros.Remove(l);
                    return true; // Livro removido com sucesso
                }
            }
            return false; // Livro não encontrado
        }

        public bool Atualizar(string isbn, Livro livroAtualizado)
        {
            foreach (Livro l in livros)
            {
                if (l.ISBN.ToString() == isbn)
                {
                    l.nomeLivro = livroAtualizado.nomeLivro;
                    l.autorLivro = livroAtualizado.autorLivro;
                    l.ISBN = livroAtualizado.ISBN;
                    l.autorIdade = livroAtualizado.autorIdade;
                    return true; // Livro atualizado com sucesso
                }
            }
            return false; // Livro não encontrado
        }
        
    }
}

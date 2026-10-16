using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Model
{
    public class Livro
    {
        public string nomeLivro { get; set; }
        public string autorLivro { get; set; }
        public int ISBN { get; set; }
        public int autorIdade { get; set; }

        public Livro(string nomeLivro, string autorLivro, int ISBN, int autorIdade)
        {
            this.nomeLivro = nomeLivro;
            this.autorLivro = autorLivro;
            this.ISBN = ISBN;
            this.autorIdade = autorIdade;
        }

    }
}

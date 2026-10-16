using System;
using System.Collections.Generic;
using System.Text;

namespace UVVkedin_forms.Model
{
    internal class Amigo
    {
        public string Apelido { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Apelido: {Apelido}, Telefone: {Telefone}, Email: {Email}";
        }

    }
}

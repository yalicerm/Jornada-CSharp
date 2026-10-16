using System;
using System.Collections.Generic;
using System.Text;

namespace CofrinhoCode.Model
{
    public class Moeda
    {
        public double valor { get; set; }
        public string nome { get; set; }

        public Moeda(double valor, string nome)
        {
            this.valor = valor;
            this.nome = nome;
        }

    }
}

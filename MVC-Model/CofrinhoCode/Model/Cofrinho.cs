using System;
using System.Collections.Generic;
using System.Text;

namespace CofrinhoCode.Model
{
    public class Cofrinho
    {
         List<Moeda> moedas = new List<Moeda>();

        public Moeda adicionar(Moeda m) //Adicionar uma moeda ao cofrinho
        {
            this.moedas.Add(m);
            return m;
        }

        public double calcularTotal() //Contar o valor total das moedas armazenadas
        {
            double total = 0;
            foreach (Moeda m in moedas)
            {
                total += m.valor;
            }

            return total;
        }

        public int totalMoedas() //Contar o número de moedas armazenadas
        {
            return moedas.Count;
        }

        public int totalValorMoeda(double valor) { //Contar o número de moedas de um determinado valor
            int count = 0;
            foreach (Moeda m in moedas)
            {
                if (m.valor == valor)
                {
                    count++;
                }
            }
            return count;
        }

        public Moeda maiorMoeda() //Retornar a moeda de maior valor armazenada
        {
            Moeda maior = null;
            foreach (Moeda m in moedas)
            {
                if (maior == null || m.valor > maior.valor)
                {
                    maior = m;
                }
            }
            return maior;
        }

        

    }
}

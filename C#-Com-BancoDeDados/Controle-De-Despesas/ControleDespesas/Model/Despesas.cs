using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDespesas.Model
{
    internal class Despesas
    {
        public string nome { get; set; }
        public int id { get; set; }
        public string descricao { get; set; } = "";
        public string categoria { get; set; } = "";
        public decimal valor { get; set; }
        public DateTime data { get; set; } 


    }
}

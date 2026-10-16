using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WpfAgendaUsandoBD.BD
{
    public class ConexaoBD
    {
        private readonly string stringConexao = "server=localhost;database=agendabd;user=root;password=01092005";

        public MySqlConnection ObterConexao()
        {
            return new MySqlConnection(stringConexao);
        }
    }
}

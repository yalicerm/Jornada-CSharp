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
        private readonly string stringConexao = "server=*****;database=*******;user=*******;password=*******";

        public MySqlConnection ObterConexao()
        {
            return new MySqlConnection(stringConexao);
        }
    }
}

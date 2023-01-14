using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DMCERP.br.com.erp.conexao
{
    public class ConnectionFactory
    {
        public NpgsqlConnection GetConnection()
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=system;Database=dmcerp;");
                return conn;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Conectar ao BD: "+e.Message);
                return null;

            }
            
        }

    }
}

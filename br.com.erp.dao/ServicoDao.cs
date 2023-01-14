using DMCERP.br.com.erp.conexao;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMCERP.br.com.erp.dao
{
    public class ServicoDao
    {
        private NpgsqlConnection conn;

        public ServicoDao()
        {
            this.conn = new ConnectionFactory().GetConnection();
        }

        #region ListService
        public DataTable ListService()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT codigo as ""Código"",
                                  descricao as ""Descrição"",
                                  valorservico as ""Valor Serviço""
                                  FROM tbl_servico ORDER BY descricao";
                               
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                NpgsqlDataAdapter mda = new NpgsqlDataAdapter(cmd);
                mda.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um Erro: " + e.Message);
                return null;
            }

        }
        #endregion
    }
}

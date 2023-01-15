using DMCERP.br.com.erp.conexao;
using DMCERP.br.com.erp.model;
using Npgsql;
using System;
using System.Data;
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

        #region FindServicePerCode
        public Servico FindServicePerCode(int code)
        {
            try
            {
                Servico s = new Servico();
                string sql = @"SELECT * FROM 
                                       tbl_servico 
                                    WHERE 
                                        codigo = @code";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@code", code);
                conn.Open();

                NpgsqlDataReader rs = cmd.ExecuteReader();

                if (rs.Read())
                {
                    s.Descricao = rs.GetString(1);
                    s.ValorServico = rs.GetDecimal(2);
                    conn.Close();
                    return s;
                }
                else
                {
                    MessageBox.Show("Código de Serviço não Cadastrado!");
                    conn.Close();
                    return null;
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um Erro:" + e.Message);
                return null;
            }
        }
        #endregion

        #region InsertService
        public void InsertService(Servico s)
        {
            try
            {
                string sql = @"INSERT INTO tbl_servico(
                                  descricao,
                                  valorservico)
                             VALUES(
                                   @descricao,
                                   @valorservico)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@descricao", s.Descricao);
                cmd.Parameters.AddWithValue("@valorservico", s.ValorServico);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Serviço Cadastrado com Sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um Erro: " + e.Message);
            }
        }
        #endregion
    }
}

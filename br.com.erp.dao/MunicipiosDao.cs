using DMCERP.br.com.erp.conexao;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMCERP.br.com.erp.model
{
    public class MunicipiosDao
    {
        private NpgsqlConnection conn;

        public MunicipiosDao()
        {
            this.conn = new ConnectionFactory().GetConnection();
        }

        #region ListaMunicipios
        public DataTable ListaMunicipios()
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT cdmunicipio as ""Código"",
                               nomemunicipio as ""Município"",
                               cduf as ""CdUF"",
                               nomeuf as ""Estado"",
                               siglauf ""UF""
                               FROM 
                                  tbl_municipio
                               ORDER BY 
                                      siglauf";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                conn.Open();

                NpgsqlDataAdapter mda = new NpgsqlDataAdapter(cmd);
                mda.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um Erro:" + e.Message);
                conn.Close();
                return null;
            }


        }
        #endregion

        #region InsertMunicipios
        public void InsertMunicipios(Municipio mun)
        {
            try
            {
                string sql = @"INSERT INTO tbl_municipio(
                                         cdmunicipio,
                                         nomemunicipio,
                                         cduf,
                                         nomeuf,
                                         siglauf)
                                VALUES(
                                       @cdmunicipio,
                                       @nomemunicipio,
                                       @cduf,
                                       @nomeuf,
                                       @siglauf)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cdmunicipio", mun.CdMunicipio);
                cmd.Parameters.AddWithValue("@nomemunicipio", mun.NomeMunicipio);
                cmd.Parameters.AddWithValue("@cduf", mun.CdUF);
                cmd.Parameters.AddWithValue("@nomeuf", mun.NomeUF);
                cmd.Parameters.AddWithValue("@siglauf", mun.SiglaUF);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Município Cadastrado com Sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um Erro: " + e.Message);
            }

        }
        #endregion

        #region UpdateCounty
        public void UpdateCounty(Municipio mun)
        {
            try
            {
                string sql = @"UPDATE tbl_municipio SET
                                      nomemunicipio = @nomemunicipio,
                                      cduf = @cduf,
                                      nomeuf = @nomeuf,
                                      siglauf = @siglauf
                                  WHERE cdmunicipio = @code";
                                      
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nomemunicipio", mun.NomeMunicipio);
                cmd.Parameters.AddWithValue("@cduf", mun.CdUF);
                cmd.Parameters.AddWithValue("@nomeuf", mun.NomeUF);
                cmd.Parameters.AddWithValue("@siglauf", mun.SiglaUF);
                cmd.Parameters.AddWithValue("@code", mun.CdMunicipio);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Município Alterado com Sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um Erro: " + e.Message);
            }
        }
        #endregion

        #region DeleteCounty
        public void DeleteCounty(Municipio mun)
        {
            try
            {
                string sql = @"DELETE FROM tbl_municipio
                                  WHERE cdmunicipio = @code";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@code", mun.CdMunicipio);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Município Excluído com Sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um Erro: " + e.Message);
            }
        }
        #endregion

        #region FindCountyPerCode
        public Municipio FindCountyPerCode(int code)
        {
            Municipio mun = new Municipio();

            string sql = @"SELECT * FROM 
                                       tbl_municipios 
                                    WHERE 
                                        cdmunicipio = @cdMun";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cdMun", code);
            conn.Open();

            NpgsqlDataReader rs = cmd.ExecuteReader();

            if (rs.Read())
            {
                mun.NomeMunicipio = rs.GetString(1);
                mun.CdUF = rs.GetInt32(2);
                mun.NomeUF = rs.GetString(3);
                mun.SiglaUF = rs.GetString(4);
                conn.Close();
                return mun;
            }
            else
            {
                MessageBox.Show("Código do Município não Cadastrado!");
                conn.Close();
                return null;
            }

        }
        #endregion

        #region FindCountyPerNome
        public DataTable FindCountyPerName(string nomemunicipio)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT cdmunicipio as ""Código"",
                               nomemunicipio as ""Município"",
                               cduf as ""CdUF"",
                               nomeuf as ""Estado"",
                               siglauf ""UF""
                               FROM 
                                  tbl_municipio
                               WHERE 
                                   nomemunicipio LIKE @nome ";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", nomemunicipio);
                conn.Open();

                NpgsqlDataAdapter mda = new NpgsqlDataAdapter(cmd);
                mda.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um Erro:" + e.Message);
                conn.Close();
                return null;
            }

        }
        #endregion

        #region FindCountyPerUF
        public DataTable FindCountyPerUF(string uf)
        {
            try
            {
                DataTable dt = new DataTable();

                string sql = @"SELECT cdmunicipio as ""Código"",
                               nomemunicipio as ""Município"",
                               cduf as ""CdUF"",
                               nomeuf as ""Estado"",
                               siglauf ""UF""
                               FROM 
                                  tbl_municipio
                               WHERE 
                                   siglauf = @uf
                               ORDER BY nomemunicipio";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uf",uf);
                conn.Open();

                NpgsqlDataAdapter mda = new NpgsqlDataAdapter(cmd);
                mda.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um Erro:" + e.Message);
                conn.Close();
                return null;
            }

        }
        #endregion


    }
}

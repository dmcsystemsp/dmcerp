using DMCERP.br.com.erp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMCERP.br.com.erp.view
{
    public partial class FrmCadastroMunicipio : Form
    {
        Municipio mun = new Municipio();

        public FrmCadastroMunicipio()
        {
            InitializeComponent();
        }



        private void FrmCadastroMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCdMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    MunicipiosDao dao = new MunicipiosDao();
                    mun = dao.FindCountyPerCode(int.Parse(txtCdMunicipio.Text));
                    if (mun != null)
                    {
                        txtNomeMunicipio.Text = mun.NomeMunicipio;
                        txtCdUF.Text = mun.CdUF.ToString();
                        txtNomUF.Text = mun.NomeUF;
                        txtSigla.Text = mun.SiglaUF;
                    }
                    else
                    {
                        txtCdMunicipio.Focus();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um Erro! ");
            }
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Municipio mun = new Municipio();
            CarregaDados(mun);

            MunicipiosDao munDao = new MunicipiosDao();
            munDao.InsertMunicipios(mun);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Municipio mun = new Municipio();
            mun.CdMunicipio = int.Parse(txtCdMunicipio.Text);
            CarregaDados(mun);

            MunicipiosDao munDao = new MunicipiosDao();
            munDao.UpdateCounty(mun);

            FrmConsultaMunicipios con = new FrmConsultaMunicipios();
            con.Show();
            this.Close();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Municipio mun = new Municipio();
            mun.CdMunicipio = int.Parse(txtCdMunicipio.Text);

            MunicipiosDao munDao = new MunicipiosDao();
            munDao.DeleteCounty(mun);

            FrmConsultaMunicipios con = new FrmConsultaMunicipios();
            con.Show();
            this.Close();

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmConsultaMunicipios con = new FrmConsultaMunicipios();
            con.Show();
            this.Close();
        }

        private void CarregaDados(Municipio mun)
        {
            try
            {
                mun.CdMunicipio = int.Parse(txtCdMunicipio.Text);
                mun.NomeMunicipio = txtNomeMunicipio.Text;
                mun.CdUF = int.Parse(txtCdUF.Text);
                mun.NomeUF = txtNomUF.Text;
                mun.SiglaUF = txtSigla.Text;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um Erro: " + e.Message);
            }
        }

    }
}

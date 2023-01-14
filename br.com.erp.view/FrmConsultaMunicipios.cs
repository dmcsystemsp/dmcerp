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
    public partial class FrmConsultaMunicipios : Form
    {
        public FrmConsultaMunicipios()
        {
            InitializeComponent();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMunicipios_Load(object sender, EventArgs e)
        {
            MunicipiosDao dao = new MunicipiosDao();
          
            dgvMunicipios.DataSource = dao.ListaMunicipios();
            
        }

        private void btnManutencao_Click(object sender, EventArgs e)
        {
            FrmCadastroMunicipio cad = new FrmCadastroMunicipio();
            cad.Show();
            this.Hide();

        }

        private void dgvMunicipios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCadastroMunicipio cad = new FrmCadastroMunicipio();
            cad.txtCdMunicipio.Text = dgvMunicipios.CurrentRow.Cells[0].Value.ToString();
            cad.Show();
            this.Hide();

        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(rdoMunicipio.Checked)
                {
                    string Busca;
                    Busca = "%" + txtPesquisa.Text + "%";
                    MunicipiosDao dao = new MunicipiosDao();
                    dgvMunicipios.DataSource = dao.FindCountyPerName(Busca);
                }
                else if(rdoUF.Checked)
                {
                    string Busca;
                    Busca = txtPesquisa.Text;
                    MunicipiosDao dao = new MunicipiosDao();
                    dgvMunicipios.DataSource = dao.FindCountyPerUF(Busca);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um Erro: ");
            }
            
        }
    }
}

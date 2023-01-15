using DMCERP.br.com.erp.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMCERP
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        
        private void tsmSair_Click(object sender, EventArgs e)
        {
            DialogResult sair;
            sair = MessageBox.Show("Deseja Realmente Sair do Sistema?",
                "Pergunta",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsmMunicipio_Click(object sender, EventArgs e)
        {
            FrmConsultaMunicipios mun = new FrmConsultaMunicipios();
            mun.Show();
        }

        private void stsServicos_Click(object sender, EventArgs e)
        {
            FrmTabelaServicos ser = new FrmTabelaServicos();
            ser.Show();
        }
    }
}

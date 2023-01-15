using DMCERP.br.com.erp.dao;
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
    public partial class FrmTabelaServicos : Form
    {
        public FrmTabelaServicos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTabelaServicos_Load(object sender, EventArgs e)
        {
            ServicoDao dao = new ServicoDao();
           
            dgvServicos.DataSource = dao.ListService();
            DataGridViewColumn codigo = dgvServicos.Columns[0];
            codigo.Width = 70;
            DataGridViewColumn descricao = dgvServicos.Columns[1];
            descricao.Width = 350;

        }

        private void btnManutencao_Click(object sender, EventArgs e)
        {
            FrmCadastroServico cad = new FrmCadastroServico();
            cad.Show();
            this.Hide();
        }

        private void dgvServicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCadastroServico cad = new FrmCadastroServico();
            cad.txtCodigo.Text = dgvServicos.CurrentRow.Cells[0].Value.ToString();
            cad.Show();
            this.Hide();
        }

        private void dgvServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

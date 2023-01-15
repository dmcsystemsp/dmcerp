using DMCERP.br.com.erp.dao;
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
    public partial class FrmCadastroServico : Form
    {
        private Servico serv = new Servico();
        public FrmCadastroServico()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Servico s = new Servico();
            CarregaDados(s);
            ServicoDao dao = new ServicoDao();
            dao.InsertService(s);

        }

        private void CarregaDados(Servico s)
        {
            try
            {
                s.Descricao = txtDescricao.Text;
                s.ValorServico = decimal.Parse(txtValorServico.Text);   
            }
            catch (Exception e )
            {
                MessageBox.Show("Ocorreu um Erro: " + e.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmTabelaServicos con = new FrmTabelaServicos();
            con.Show();
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
                if (e.KeyChar == 13)
                {
                    ServicoDao dao = new ServicoDao();
                    serv = dao.FindServicePerCode(int.Parse(txtCodigo.Text));
                    if (serv != null)
                    {
                        txtDescricao.Text = serv.Descricao;
                        txtValorServico.Text = serv.ValorServico.ToString();
                    }
                    else
                    {
                        txtCodigo.Focus();
                    }

                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um Erro! ");
            }
        }

        private void FrmCadastroServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== 13) {
                SendKeys.Send("{TAB}");
            }
        }

        private void FrmCadastroServico_Load(object sender, EventArgs e)
        {
            
        }
    }
}

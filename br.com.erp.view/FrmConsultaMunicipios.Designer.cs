namespace DMCERP.br.com.erp.view
{
    partial class FrmConsultaMunicipios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMunicipios = new System.Windows.Forms.Panel();
            this.lblMunicipios = new System.Windows.Forms.Label();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdoUF = new System.Windows.Forms.RadioButton();
            this.rdoMunicipio = new System.Windows.Forms.RadioButton();
            this.dgvMunicipios = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnManutencao = new System.Windows.Forms.Button();
            this.pnlMunicipios.SuspendLayout();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMunicipios
            // 
            this.pnlMunicipios.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlMunicipios.Controls.Add(this.lblMunicipios);
            this.pnlMunicipios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMunicipios.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMunicipios.Location = new System.Drawing.Point(0, 0);
            this.pnlMunicipios.Name = "pnlMunicipios";
            this.pnlMunicipios.Size = new System.Drawing.Size(796, 48);
            this.pnlMunicipios.TabIndex = 0;
            // 
            // lblMunicipios
            // 
            this.lblMunicipios.AutoSize = true;
            this.lblMunicipios.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMunicipios.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipios.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblMunicipios.Location = new System.Drawing.Point(0, 0);
            this.lblMunicipios.Name = "lblMunicipios";
            this.lblMunicipios.Size = new System.Drawing.Size(222, 28);
            this.lblMunicipios.TabIndex = 0;
            this.lblMunicipios.Text = "Tabela de Municípios";
            this.lblMunicipios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Controls.Add(this.rdoUF);
            this.grpPesquisa.Controls.Add(this.rdoMunicipio);
            this.grpPesquisa.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisa.Location = new System.Drawing.Point(5, 54);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(795, 73);
            this.grpPesquisa.TabIndex = 1;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa Municípios";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(232, 28);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(551, 29);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // rdoUF
            // 
            this.rdoUF.AutoSize = true;
            this.rdoUF.Checked = true;
            this.rdoUF.Location = new System.Drawing.Point(155, 28);
            this.rdoUF.Name = "rdoUF";
            this.rdoUF.Size = new System.Drawing.Size(52, 26);
            this.rdoUF.TabIndex = 1;
            this.rdoUF.TabStop = true;
            this.rdoUF.Text = "UF";
            this.rdoUF.UseVisualStyleBackColor = true;
            // 
            // rdoMunicipio
            // 
            this.rdoMunicipio.AutoSize = true;
            this.rdoMunicipio.Checked = true;
            this.rdoMunicipio.Location = new System.Drawing.Point(7, 28);
            this.rdoMunicipio.Name = "rdoMunicipio";
            this.rdoMunicipio.Size = new System.Drawing.Size(105, 26);
            this.rdoMunicipio.TabIndex = 0;
            this.rdoMunicipio.TabStop = true;
            this.rdoMunicipio.Text = "Município";
            this.rdoMunicipio.UseVisualStyleBackColor = true;
            // 
            // dgvMunicipios
            // 
            this.dgvMunicipios.AllowUserToAddRows = false;
            this.dgvMunicipios.AllowUserToDeleteRows = false;
            this.dgvMunicipios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMunicipios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMunicipios.Location = new System.Drawing.Point(5, 133);
            this.dgvMunicipios.Name = "dgvMunicipios";
            this.dgvMunicipios.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMunicipios.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMunicipios.RowHeadersWidth = 70;
            this.dgvMunicipios.RowTemplate.Height = 24;
            this.dgvMunicipios.Size = new System.Drawing.Size(783, 332);
            this.dgvMunicipios.TabIndex = 2;
            this.dgvMunicipios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMunicipios_CellDoubleClick);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSair.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(676, 474);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 44);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnManutencao
            // 
            this.btnManutencao.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnManutencao.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManutencao.Location = new System.Drawing.Point(198, 474);
            this.btnManutencao.Name = "btnManutencao";
            this.btnManutencao.Size = new System.Drawing.Size(312, 44);
            this.btnManutencao.TabIndex = 4;
            this.btnManutencao.Text = "Manutenção";
            this.btnManutencao.UseVisualStyleBackColor = false;
            this.btnManutencao.Click += new System.EventHandler(this.btnManutencao_Click);
            // 
            // FrmConsultaMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 530);
            this.Controls.Add(this.btnManutencao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvMunicipios);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.pnlMunicipios);
            this.Name = "FrmConsultaMunicipios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMunicipios";
            this.Load += new System.EventHandler(this.FrmMunicipios_Load);
            this.pnlMunicipios.ResumeLayout(false);
            this.pnlMunicipios.PerformLayout();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMunicipios;
        private System.Windows.Forms.Label lblMunicipios;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdoUF;
        private System.Windows.Forms.RadioButton rdoMunicipio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnManutencao;
        private System.Windows.Forms.DataGridView dgvMunicipios;
    }
}
namespace DMCERP.br.com.erp.view
{
    partial class FrmSangria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgvSangria = new System.Windows.Forms.DataGridView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdoUF = new System.Windows.Forms.RadioButton();
            this.rdoMunicipio = new System.Windows.Forms.RadioButton();
            this.pnlMunicipios = new System.Windows.Forms.Panel();
            this.lblSangrias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSangria)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.pnlMunicipios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSair.Location = new System.Drawing.Point(666, 467);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 44);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // dgvSangria
            // 
            this.dgvSangria.AllowUserToAddRows = false;
            this.dgvSangria.AllowUserToDeleteRows = false;
            this.dgvSangria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSangria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSangria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSangria.Location = new System.Drawing.Point(-5, 126);
            this.dgvSangria.Name = "dgvSangria";
            this.dgvSangria.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSangria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSangria.RowHeadersWidth = 51;
            this.dgvSangria.RowTemplate.Height = 24;
            this.dgvSangria.Size = new System.Drawing.Size(783, 332);
            this.dgvSangria.TabIndex = 6;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Controls.Add(this.rdoUF);
            this.grpPesquisa.Controls.Add(this.rdoMunicipio);
            this.grpPesquisa.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisa.Location = new System.Drawing.Point(-5, 47);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(795, 73);
            this.grpPesquisa.TabIndex = 5;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa Sangrias";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(278, 28);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(495, 29);
            this.txtPesquisa.TabIndex = 2;
            // 
            // rdoUF
            // 
            this.rdoUF.AutoSize = true;
            this.rdoUF.Checked = true;
            this.rdoUF.Location = new System.Drawing.Point(175, 28);
            this.rdoUF.Name = "rdoUF";
            this.rdoUF.Size = new System.Drawing.Size(88, 26);
            this.rdoUF.TabIndex = 1;
            this.rdoUF.TabStop = true;
            this.rdoUF.Text = "Usuário";
            this.rdoUF.UseVisualStyleBackColor = true;
            // 
            // rdoMunicipio
            // 
            this.rdoMunicipio.AutoSize = true;
            this.rdoMunicipio.Checked = true;
            this.rdoMunicipio.Location = new System.Drawing.Point(7, 28);
            this.rdoMunicipio.Name = "rdoMunicipio";
            this.rdoMunicipio.Size = new System.Drawing.Size(158, 26);
            this.rdoMunicipio.TabIndex = 0;
            this.rdoMunicipio.TabStop = true;
            this.rdoMunicipio.Text = "Data Movimento";
            this.rdoMunicipio.UseVisualStyleBackColor = true;
            // 
            // pnlMunicipios
            // 
            this.pnlMunicipios.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlMunicipios.Controls.Add(this.lblSangrias);
            this.pnlMunicipios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMunicipios.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMunicipios.Location = new System.Drawing.Point(0, 0);
            this.pnlMunicipios.Name = "pnlMunicipios";
            this.pnlMunicipios.Size = new System.Drawing.Size(780, 48);
            this.pnlMunicipios.TabIndex = 4;
            // 
            // lblSangrias
            // 
            this.lblSangrias.AutoSize = true;
            this.lblSangrias.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSangrias.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSangrias.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblSangrias.Location = new System.Drawing.Point(0, 0);
            this.lblSangrias.Name = "lblSangrias";
            this.lblSangrias.Size = new System.Drawing.Size(199, 28);
            this.lblSangrias.TabIndex = 0;
            this.lblSangrias.Text = "Tabela de Sangrias";
            this.lblSangrias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 504);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvSangria);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.pnlMunicipios);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSangria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSangria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSangria)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.pnlMunicipios.ResumeLayout(false);
            this.pnlMunicipios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgvSangria;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdoUF;
        private System.Windows.Forms.RadioButton rdoMunicipio;
        private System.Windows.Forms.Panel pnlMunicipios;
        private System.Windows.Forms.Label lblSangrias;
    }
}
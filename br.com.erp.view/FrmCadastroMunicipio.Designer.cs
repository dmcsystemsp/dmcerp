namespace DMCERP.br.com.erp.view
{
    partial class FrmCadastroMunicipio
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
            this.pnlMunicipios = new System.Windows.Forms.Panel();
            this.lblCadastroMunicipios = new System.Windows.Forms.Label();
            this.lblCdMunicipio = new System.Windows.Forms.Label();
            this.txtCdMunicipio = new System.Windows.Forms.TextBox();
            this.txtNomeMunicipio = new System.Windows.Forms.TextBox();
            this.lblNomeMunicipio = new System.Windows.Forms.Label();
            this.txtCdUF = new System.Windows.Forms.TextBox();
            this.lblCdUF = new System.Windows.Forms.Label();
            this.txtNomUF = new System.Windows.Forms.TextBox();
            this.lblNomeUF = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlMunicipios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMunicipios
            // 
            this.pnlMunicipios.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlMunicipios.Controls.Add(this.lblCadastroMunicipios);
            this.pnlMunicipios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMunicipios.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMunicipios.Location = new System.Drawing.Point(0, 0);
            this.pnlMunicipios.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMunicipios.Name = "pnlMunicipios";
            this.pnlMunicipios.Size = new System.Drawing.Size(665, 66);
            this.pnlMunicipios.TabIndex = 1;
            // 
            // lblCadastroMunicipios
            // 
            this.lblCadastroMunicipios.AutoSize = true;
            this.lblCadastroMunicipios.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroMunicipios.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblCadastroMunicipios.Location = new System.Drawing.Point(204, 22);
            this.lblCadastroMunicipios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastroMunicipios.Name = "lblCadastroMunicipios";
            this.lblCadastroMunicipios.Size = new System.Drawing.Size(246, 28);
            this.lblCadastroMunicipios.TabIndex = 0;
            this.lblCadastroMunicipios.Text = "Cadastro de Municípios";
            this.lblCadastroMunicipios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCdMunicipio
            // 
            this.lblCdMunicipio.AutoSize = true;
            this.lblCdMunicipio.Location = new System.Drawing.Point(12, 83);
            this.lblCdMunicipio.Name = "lblCdMunicipio";
            this.lblCdMunicipio.Size = new System.Drawing.Size(143, 22);
            this.lblCdMunicipio.TabIndex = 2;
            this.lblCdMunicipio.Text = "Código Município";
            // 
            // txtCdMunicipio
            // 
            this.txtCdMunicipio.Location = new System.Drawing.Point(16, 108);
            this.txtCdMunicipio.MaxLength = 7;
            this.txtCdMunicipio.Name = "txtCdMunicipio";
            this.txtCdMunicipio.Size = new System.Drawing.Size(139, 29);
            this.txtCdMunicipio.TabIndex = 3;
            this.txtCdMunicipio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCdMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCdMunicipio_KeyPress);
            // 
            // txtNomeMunicipio
            // 
            this.txtNomeMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeMunicipio.Location = new System.Drawing.Point(172, 108);
            this.txtNomeMunicipio.MaxLength = 40;
            this.txtNomeMunicipio.Name = "txtNomeMunicipio";
            this.txtNomeMunicipio.Size = new System.Drawing.Size(481, 29);
            this.txtNomeMunicipio.TabIndex = 5;
            // 
            // lblNomeMunicipio
            // 
            this.lblNomeMunicipio.AutoSize = true;
            this.lblNomeMunicipio.Location = new System.Drawing.Point(168, 83);
            this.lblNomeMunicipio.Name = "lblNomeMunicipio";
            this.lblNomeMunicipio.Size = new System.Drawing.Size(135, 22);
            this.lblNomeMunicipio.TabIndex = 4;
            this.lblNomeMunicipio.Text = "Nome Município";
            // 
            // txtCdUF
            // 
            this.txtCdUF.Location = new System.Drawing.Point(16, 170);
            this.txtCdUF.MaxLength = 7;
            this.txtCdUF.Name = "txtCdUF";
            this.txtCdUF.Size = new System.Drawing.Size(139, 29);
            this.txtCdUF.TabIndex = 7;
            this.txtCdUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCdUF
            // 
            this.lblCdUF.AutoSize = true;
            this.lblCdUF.Location = new System.Drawing.Point(12, 145);
            this.lblCdUF.Name = "lblCdUF";
            this.lblCdUF.Size = new System.Drawing.Size(89, 22);
            this.lblCdUF.TabIndex = 6;
            this.lblCdUF.Text = "Código UF";
            // 
            // txtNomUF
            // 
            this.txtNomUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomUF.Location = new System.Drawing.Point(172, 170);
            this.txtNomUF.MaxLength = 30;
            this.txtNomUF.Name = "txtNomUF";
            this.txtNomUF.Size = new System.Drawing.Size(399, 29);
            this.txtNomUF.TabIndex = 9;
            // 
            // lblNomeUF
            // 
            this.lblNomeUF.AutoSize = true;
            this.lblNomeUF.Location = new System.Drawing.Point(168, 145);
            this.lblNomeUF.Name = "lblNomeUF";
            this.lblNomeUF.Size = new System.Drawing.Size(113, 22);
            this.lblNomeUF.TabIndex = 8;
            this.lblNomeUF.Text = "Nome Estado";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(584, 140);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(31, 22);
            this.lblUF.TabIndex = 10;
            this.lblUF.Text = "UF";
            // 
            // txtSigla
            // 
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.Location = new System.Drawing.Point(588, 170);
            this.txtSigla.MaxLength = 2;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(65, 29);
            this.txtSigla.TabIndex = 11;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnIncluir.Location = new System.Drawing.Point(128, 220);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(108, 44);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.Location = new System.Drawing.Point(242, 220);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 44);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.Location = new System.Drawing.Point(356, 220);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 44);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(470, 220);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 44);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmCadastroMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 273);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtNomUF);
            this.Controls.Add(this.lblNomeUF);
            this.Controls.Add(this.txtCdUF);
            this.Controls.Add(this.lblCdUF);
            this.Controls.Add(this.txtNomeMunicipio);
            this.Controls.Add(this.lblNomeMunicipio);
            this.Controls.Add(this.txtCdMunicipio);
            this.Controls.Add(this.lblCdMunicipio);
            this.Controls.Add(this.pnlMunicipios);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadastroMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroMunicipio";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCadastroMunicipio_KeyPress);
            this.pnlMunicipios.ResumeLayout(false);
            this.pnlMunicipios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMunicipios;
        private System.Windows.Forms.Label lblCadastroMunicipios;
        private System.Windows.Forms.Label lblCdMunicipio;
        private System.Windows.Forms.TextBox txtNomeMunicipio;
        private System.Windows.Forms.Label lblNomeMunicipio;
        private System.Windows.Forms.TextBox txtCdUF;
        private System.Windows.Forms.Label lblCdUF;
        private System.Windows.Forms.TextBox txtNomUF;
        private System.Windows.Forms.Label lblNomeUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.TextBox txtCdMunicipio;
    }
}
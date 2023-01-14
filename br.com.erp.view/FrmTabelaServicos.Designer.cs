namespace DMCERP.br.com.erp.view
{
    partial class FrmTabelaServicos
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
            this.pnlServicos = new System.Windows.Forms.Panel();
            this.lblServicos = new System.Windows.Forms.Label();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdoDescricao = new System.Windows.Forms.RadioButton();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.btnManutencao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlServicos.SuspendLayout();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlServicos
            // 
            this.pnlServicos.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlServicos.Controls.Add(this.lblServicos);
            this.pnlServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlServicos.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlServicos.Location = new System.Drawing.Point(0, 0);
            this.pnlServicos.Name = "pnlServicos";
            this.pnlServicos.Size = new System.Drawing.Size(659, 48);
            this.pnlServicos.TabIndex = 1;
            // 
            // lblServicos
            // 
            this.lblServicos.AutoSize = true;
            this.lblServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServicos.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblServicos.Location = new System.Drawing.Point(0, 0);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(195, 28);
            this.lblServicos.TabIndex = 0;
            this.lblServicos.Text = "Tabela de Serviços";
            this.lblServicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.txtPesquisa);
            this.grpPesquisa.Controls.Add(this.rdoDescricao);
            this.grpPesquisa.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisa.Location = new System.Drawing.Point(5, 54);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(643, 73);
            this.grpPesquisa.TabIndex = 2;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa Serviços";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(130, 28);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(503, 29);
            this.txtPesquisa.TabIndex = 2;
            // 
            // rdoDescricao
            // 
            this.rdoDescricao.AutoSize = true;
            this.rdoDescricao.Checked = true;
            this.rdoDescricao.Location = new System.Drawing.Point(7, 28);
            this.rdoDescricao.Name = "rdoDescricao";
            this.rdoDescricao.Size = new System.Drawing.Size(104, 26);
            this.rdoDescricao.TabIndex = 0;
            this.rdoDescricao.TabStop = true;
            this.rdoDescricao.Text = "Descrição";
            this.rdoDescricao.UseVisualStyleBackColor = true;
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToAddRows = false;
            this.dgvServicos.AllowUserToDeleteRows = false;
            this.dgvServicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvServicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvServicos.ColumnHeadersHeight = 29;
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServicos.Location = new System.Drawing.Point(5, 133);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicos.RowHeadersWidth = 30;
            this.dgvServicos.RowTemplate.Height = 24;
            this.dgvServicos.Size = new System.Drawing.Size(633, 196);
            this.dgvServicos.TabIndex = 3;
            // 
            // btnManutencao
            // 
            this.btnManutencao.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnManutencao.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManutencao.Location = new System.Drawing.Point(5, 348);
            this.btnManutencao.Name = "btnManutencao";
            this.btnManutencao.Size = new System.Drawing.Size(413, 44);
            this.btnManutencao.TabIndex = 6;
            this.btnManutencao.Text = "Manutenção";
            this.btnManutencao.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSair.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(508, 348);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(139, 44);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmTabelaServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 407);
            this.ControlBox = false;
            this.Controls.Add(this.btnManutencao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvServicos);
            this.Controls.Add(this.grpPesquisa);
            this.Controls.Add(this.pnlServicos);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTabelaServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmServicos";
            this.Load += new System.EventHandler(this.FrmTabelaServicos_Load);
            this.pnlServicos.ResumeLayout(false);
            this.pnlServicos.PerformLayout();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlServicos;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdoDescricao;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.Button btnManutencao;
        private System.Windows.Forms.Button btnSair;
    }
}
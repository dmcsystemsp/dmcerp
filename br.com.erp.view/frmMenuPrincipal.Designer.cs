namespace DMCERP
{
    partial class frmMenuPrincipal
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
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vEndasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMenuPrincipal = new System.Windows.Forms.StatusStrip();
            this.tssLblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmMunicipio = new System.Windows.Forms.ToolStripMenuItem();
            this.stsServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.ssMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.estoquesToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.vEndasToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.tsmSair});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1150, 28);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMunicipio,
            this.stsServicos});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // estoquesToolStripMenuItem
            // 
            this.estoquesToolStripMenuItem.Name = "estoquesToolStripMenuItem";
            this.estoquesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.estoquesToolStripMenuItem.Text = "Estoques";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // vEndasToolStripMenuItem
            // 
            this.vEndasToolStripMenuItem.Name = "vEndasToolStripMenuItem";
            this.vEndasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.vEndasToolStripMenuItem.Text = "Vendas";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(48, 24);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // ssMenuPrincipal
            // 
            this.ssMenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblData,
            this.tssData});
            this.ssMenuPrincipal.Location = new System.Drawing.Point(0, 579);
            this.ssMenuPrincipal.Name = "ssMenuPrincipal";
            this.ssMenuPrincipal.Size = new System.Drawing.Size(1150, 26);
            this.ssMenuPrincipal.TabIndex = 3;
            this.ssMenuPrincipal.Text = "statusStrip1";
            // 
            // tssLblData
            // 
            this.tssLblData.Name = "tssLblData";
            this.tssLblData.Size = new System.Drawing.Size(48, 20);
            this.tssLblData.Text = "Data: ";
            // 
            // tssData
            // 
            this.tssData.Name = "tssData";
            this.tssData.Size = new System.Drawing.Size(85, 20);
            this.tssData.Text = "11/01/2023";
            // 
            // tsmMunicipio
            // 
            this.tsmMunicipio.Name = "tsmMunicipio";
            this.tsmMunicipio.Size = new System.Drawing.Size(224, 26);
            this.tsmMunicipio.Text = "Municípios";
            this.tsmMunicipio.Click += new System.EventHandler(this.tsmMunicipio_Click);
            // 
            // stsServicos
            // 
            this.stsServicos.Name = "stsServicos";
            this.stsServicos.Size = new System.Drawing.Size(224, 26);
            this.stsServicos.Text = "Serviços";
            this.stsServicos.Click += new System.EventHandler(this.stsServicos_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DMCERP.Properties.Resources.ERPMenuPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 605);
            this.Controls.Add(this.ssMenuPrincipal);
            this.Controls.Add(this.msPrincipal);
            this.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMCERP - Gestor Empresarial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ssMenuPrincipal.ResumeLayout(false);
            this.ssMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vEndasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.StatusStrip ssMenuPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel tssLblData;
        private System.Windows.Forms.ToolStripStatusLabel tssData;
        private System.Windows.Forms.ToolStripMenuItem tsmMunicipio;
        private System.Windows.Forms.ToolStripMenuItem stsServicos;
    }
}
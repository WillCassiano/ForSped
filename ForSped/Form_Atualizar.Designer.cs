namespace ForSPED
{
    partial class Form_Atualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Atualizar));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.list_AtualizarSistema = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.list_AtualizarBanco = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.list_AtualizarExecutavel = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminhoParaAtualizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminhoParaExeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.list_AtualizarSistema);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(160, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sistema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // list_AtualizarSistema
            // 
            this.list_AtualizarSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_AtualizarSistema.FormattingEnabled = true;
            this.list_AtualizarSistema.Location = new System.Drawing.Point(3, 3);
            this.list_AtualizarSistema.Name = "list_AtualizarSistema";
            this.list_AtualizarSistema.Size = new System.Drawing.Size(154, 249);
            this.list_AtualizarSistema.TabIndex = 0;
            this.list_AtualizarSistema.DoubleClick += new System.EventHandler(this.list_AtualizarSistema_DoubleClick);
            this.list_AtualizarSistema.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_AtualizarSistema_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.list_AtualizarBanco);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(160, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Banco";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // list_AtualizarBanco
            // 
            this.list_AtualizarBanco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_AtualizarBanco.FormattingEnabled = true;
            this.list_AtualizarBanco.Location = new System.Drawing.Point(3, 3);
            this.list_AtualizarBanco.Name = "list_AtualizarBanco";
            this.list_AtualizarBanco.Size = new System.Drawing.Size(154, 249);
            this.list_AtualizarBanco.TabIndex = 0;
            this.list_AtualizarBanco.DoubleClick += new System.EventHandler(this.list_Atualizar_DoubleClick);
            this.list_AtualizarBanco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_Atualizar_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(168, 281);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.list_AtualizarExecutavel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(160, 255);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Executavel";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // list_AtualizarExecutavel
            // 
            this.list_AtualizarExecutavel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_AtualizarExecutavel.FormattingEnabled = true;
            this.list_AtualizarExecutavel.Location = new System.Drawing.Point(0, 0);
            this.list_AtualizarExecutavel.Name = "list_AtualizarExecutavel";
            this.list_AtualizarExecutavel.Size = new System.Drawing.Size(160, 255);
            this.list_AtualizarExecutavel.TabIndex = 0;
            this.list_AtualizarExecutavel.DoubleClick += new System.EventHandler(this.list_AtualizarExecutavel_DoubleClick);
            this.list_AtualizarExecutavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_AtualizarExecutavel_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(168, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caminhoParaAtualizadoresToolStripMenuItem,
            this.caminhoParaExeToolStripMenuItem});
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(161, 19);
            this.configurarToolStripMenuItem.Text = "Configurar";
            // 
            // caminhoParaAtualizadoresToolStripMenuItem
            // 
            this.caminhoParaAtualizadoresToolStripMenuItem.Name = "caminhoParaAtualizadoresToolStripMenuItem";
            this.caminhoParaAtualizadoresToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.caminhoParaAtualizadoresToolStripMenuItem.Text = "Caminho para Sistema";
            this.caminhoParaAtualizadoresToolStripMenuItem.Click += new System.EventHandler(this.caminhoParaAtualizadoresToolStripMenuItem_Click);
            // 
            // caminhoParaExeToolStripMenuItem
            // 
            this.caminhoParaExeToolStripMenuItem.Name = "caminhoParaExeToolStripMenuItem";
            this.caminhoParaExeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.caminhoParaExeToolStripMenuItem.Text = "Caminho para Executaveis";
            this.caminhoParaExeToolStripMenuItem.Click += new System.EventHandler(this.caminhoParaExeToolStripMenuItem_Click);
            // 
            // Form_Atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(168, 306);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_Atualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Atualizar..";
            this.Load += new System.EventHandler(this.Form_Atualizar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Atualizar_KeyDown);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox list_AtualizarBanco;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox list_AtualizarSistema;
        private System.Windows.Forms.ListBox list_AtualizarExecutavel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caminhoParaExeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caminhoParaAtualizadoresToolStripMenuItem;

    }
}
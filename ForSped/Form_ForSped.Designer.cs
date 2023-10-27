namespace ForSPED
{
    partial class Form_ForSped
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ForSped));
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Ecosped = new System.Windows.Forms.Button();
            this.btn_SpedFiscal = new System.Windows.Forms.Button();
            this.btn_SpedContr = new System.Windows.Forms.Button();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVersaoexe = new System.Windows.Forms.Label();
            this.lbVersaodb = new System.Windows.Forms.Label();
            this.lb_Pasta = new System.Windows.Forms.Label();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_NFe = new System.Windows.Forms.Button();
            this.btn_Eco = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnl_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(11, 11);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(79, 23);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Ecosped
            // 
            this.btn_Ecosped.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ecosped.ForeColor = System.Drawing.Color.Blue;
            this.btn_Ecosped.Location = new System.Drawing.Point(12, 37);
            this.btn_Ecosped.Name = "btn_Ecosped";
            this.btn_Ecosped.Size = new System.Drawing.Size(165, 23);
            this.btn_Ecosped.TabIndex = 5;
            this.btn_Ecosped.Text = "EcoSped 2.0";
            this.btn_Ecosped.UseVisualStyleBackColor = true;
            this.btn_Ecosped.Click += new System.EventHandler(this.btn_Ecosped_Click);
            // 
            // btn_SpedFiscal
            // 
            this.btn_SpedFiscal.Location = new System.Drawing.Point(12, 63);
            this.btn_SpedFiscal.Name = "btn_SpedFiscal";
            this.btn_SpedFiscal.Size = new System.Drawing.Size(79, 23);
            this.btn_SpedFiscal.TabIndex = 8;
            this.btn_SpedFiscal.Text = "Sped Fiscal";
            this.btn_SpedFiscal.UseVisualStyleBackColor = true;
            this.btn_SpedFiscal.Click += new System.EventHandler(this.btn_SpedFiscal_Click);
            // 
            // btn_SpedContr
            // 
            this.btn_SpedContr.Location = new System.Drawing.Point(100, 63);
            this.btn_SpedContr.Name = "btn_SpedContr";
            this.btn_SpedContr.Size = new System.Drawing.Size(78, 23);
            this.btn_SpedContr.TabIndex = 9;
            this.btn_SpedContr.Text = "Sped Cont...";
            this.btn_SpedContr.UseVisualStyleBackColor = true;
            this.btn_SpedContr.Click += new System.EventHandler(this.btn_SpedContr_Click);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Menu.Controls.Add(this.panel1);
            this.pnl_Menu.Controls.Add(this.btn_Atualizar);
            this.pnl_Menu.Controls.Add(this.btn_NFe);
            this.pnl_Menu.Controls.Add(this.btn_Eco);
            this.pnl_Menu.Controls.Add(this.btn_SpedContr);
            this.pnl_Menu.Controls.Add(this.btn_Alterar);
            this.pnl_Menu.Controls.Add(this.btn_SpedFiscal);
            this.pnl_Menu.Controls.Add(this.btn_Ecosped);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.MaximumSize = new System.Drawing.Size(188, 184);
            this.pnl_Menu.MinimumSize = new System.Drawing.Size(188, 184);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(188, 184);
            this.pnl_Menu.TabIndex = 0;
            this.pnl_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Menu_MouseDown);
            this.pnl_Menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Menu_MouseMove);
            this.pnl_Menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Menu_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbVersaoexe);
            this.panel1.Controls.Add(this.lbVersaodb);
            this.panel1.Controls.Add(this.lb_Pasta);
            this.panel1.Location = new System.Drawing.Point(13, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 50);
            this.panel1.TabIndex = 13;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // lbVersaoexe
            // 
            this.lbVersaoexe.AutoSize = true;
            this.lbVersaoexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersaoexe.ForeColor = System.Drawing.Color.Teal;
            this.lbVersaoexe.Location = new System.Drawing.Point(5, 31);
            this.lbVersaoexe.Name = "lbVersaoexe";
            this.lbVersaoexe.Size = new System.Drawing.Size(66, 13);
            this.lbVersaoexe.TabIndex = 14;
            this.lbVersaoexe.Text = "Versão exe: ";
            this.lbVersaoexe.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // lbVersaodb
            // 
            this.lbVersaodb.AutoSize = true;
            this.lbVersaodb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersaodb.ForeColor = System.Drawing.Color.Teal;
            this.lbVersaodb.Location = new System.Drawing.Point(4, 17);
            this.lbVersaodb.Name = "lbVersaodb";
            this.lbVersaodb.Size = new System.Drawing.Size(61, 13);
            this.lbVersaodb.TabIndex = 13;
            this.lbVersaodb.Text = "Versão db: ";
            this.lbVersaodb.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // lb_Pasta
            // 
            this.lb_Pasta.AutoSize = true;
            this.lb_Pasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pasta.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lb_Pasta.Location = new System.Drawing.Point(4, 4);
            this.lb_Pasta.Name = "lb_Pasta";
            this.lb_Pasta.Size = new System.Drawing.Size(129, 13);
            this.lb_Pasta.TabIndex = 12;
            this.lb_Pasta.Text = "Pasta do banco de dados";
            this.lb_Pasta.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(99, 11);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(76, 23);
            this.btn_Atualizar.TabIndex = 2;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_NFe
            // 
            this.btn_NFe.Location = new System.Drawing.Point(99, 89);
            this.btn_NFe.Name = "btn_NFe";
            this.btn_NFe.Size = new System.Drawing.Size(78, 23);
            this.btn_NFe.TabIndex = 11;
            this.btn_NFe.Text = "NFe";
            this.btn_NFe.UseVisualStyleBackColor = true;
            this.btn_NFe.Click += new System.EventHandler(this.btn_NFe_Click);
            // 
            // btn_Eco
            // 
            this.btn_Eco.Location = new System.Drawing.Point(13, 89);
            this.btn_Eco.Name = "btn_Eco";
            this.btn_Eco.Size = new System.Drawing.Size(78, 23);
            this.btn_Eco.TabIndex = 10;
            this.btn_Eco.Text = "Eco";
            this.btn_Eco.UseVisualStyleBackColor = true;
            this.btn_Eco.Click += new System.EventHandler(this.btn_Eco_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Selecione o caminho para o banco de dados";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.SelectedPath = "C:\\ecosis\\dados";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ForSped";
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(110, 48);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersao,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 186);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(188, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVersao
            // 
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(31, 17);
            this.lblVersao.Text = "1.0.0.0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.IndianRed;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "by Willian B. C";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_ForSped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(188, 208);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnl_Menu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_ForSped";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ForSPED";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form_ForSped_Activated);
            this.Deactivate += new System.EventHandler(this.Form_ForSped_Deactivate);
            this.Load += new System.EventHandler(this.Form_ForSped_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_ForSped_KeyDown);
            this.Resize += new System.EventHandler(this.Form_ForSped_Resize);
            this.pnl_Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Ecosped;
        private System.Windows.Forms.Button btn_SpedFiscal;
        private System.Windows.Forms.Button btn_SpedContr;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Button btn_NFe;
        private System.Windows.Forms.Button btn_Eco;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Label lb_Pasta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbVersaoexe;
        private System.Windows.Forms.Label lbVersaodb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblVersao;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}


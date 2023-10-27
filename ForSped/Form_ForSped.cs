using FirebirdSql.Data.FirebirdClient;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ForSPED
{
    public partial class Form_ForSped : Form
    {
        private string _versao = string.Empty;
        private string stConect = string.Empty;
        public Form_ForSped()
        {
            InitializeComponent();
        }

        bool drag;
        Point offset;

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            Form_Search s = new Form_Search(this);
            Point p = new Point(this.DesktopLocation.X - s.Width, this.DesktopLocation.Y);
            s.DesktopLocation = p;
            s.Show();
        }

        private void btn_Ecosped_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\ecosis\windows\ecosped.exe"))
                Process.Start(@"C:\ecosis\windows\ecosped.exe");
            else
                MessageBox.Show("Arquivo não encontrado, verifique..", "Aviso..");
        }

        private void btn_SpedFiscal_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Program Files (x86)\Programas_SPED\Fiscal2"))
                Process.Start(@"C:\Program Files (x86)\Programas_SPED\Fiscal2\spedfiscal.exe");
            else if (Directory.Exists(@"C:\Program Files\Programas_SPED\Fiscal2"))
                Process.Start(@"C:\Program Files\Programas_SPED\Fiscal2\spedfiscal.exe");
            else
                MessageBox.Show("Arquivo não encontrado, verifique..", "Aviso..");
        }

        private void btn_SpedContr_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Program Files (x86)\Programas_SPED\PisCofins2"))
                Process.Start(@"C:\Program Files (x86)\Programas_SPED\PisCofins2\spedContribuicoes.exe");
            else if (Directory.Exists(@"C:\Program Files\Programas_SPED\PisCofins2"))
                Process.Start(@"C:\Program Files\Programas_SPED\PisCofins2\spedContribuicoes.exe");
            else
                MessageBox.Show("Arquivo não encontrado, verifique..", "Aviso..");
        }

        private void Form_ForSped_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipTitle = "Aviso";
                notifyIcon.BalloonTipText = "ForSped continua executando, clique aqui para abrir novamente..";
                notifyIcon.ShowBalloonTip(30);
                //this.Visible = false;
            }
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void Form_ForSped_Deactivate(object sender, EventArgs e)
        {
            try
            {
                this.Opacity = 0.6;
            }
            catch
            {
            }
        }

        private void Form_ForSped_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void Form_ForSped_Load(object sender, EventArgs e)
        {
            lblVersao.Text = $"Versão: {Application.ProductVersion}";
            this.DesktopLocation = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 0);
            InformacoesBanco();
        }


        /* ### PEGAR INFORMAÇÕES DO BANCO DE DADOS | VERSÕES | ###*/
        public void InformacoesBanco()
        {
            stConect = $@"Database={CapturaPastaBanco()}; UserId=SYSDBA; Password=masterkey; Port=3050";

            FbConnection con = new FbConnection(stConect);
            FbCommand cmd;
            try
            {
                con.Open();
                cmd = new FbCommand("select max(versao) from ECO$CTRLSCRIPTS", con);
                FbDataReader rd = cmd.ExecuteReader();
                string versaoDB = "";
                while (rd.Read())
                {
                    versaoDB = rd.GetString(0).Trim();
                    lbVersaodb.Text = "Versão db:      " + versaoDB;
                }

                cmd = new FbCommand("select max(versao) from tgerlicenca", con);
                FbDataReader rd2 = cmd.ExecuteReader();
                while (rd2.Read())
                {
                    string versao = rd2.GetString(0);
                    if (versao != null && versao != "")
                    {
                        _versao = versao;
                        lbVersaoexe.Text = "Versão exe:    " + _versao;
                    }
                }


                BuscarExecutavel();

            }
            catch (FbException er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void BuscarExecutavel()
        {
            Config c = new Config();
            if (Directory.Exists(c.pathExe))
            {
                string[] file = Directory.GetFiles(c.pathExe, "*.*")
                                            .Where(f => f.ToLower().EndsWith(".zip") ||
                                                        f.ToLower().EndsWith(".rar"))
                                            .ToArray();

                string versao = "";
                string versaoFormated = Int64.Parse(_versao.Substring(0, 5)).ToString(@"0\.0\.000");

                for (int i = 0; i < file.Length; i++)
                {
                    if (file[i].Contains(versaoFormated))
                    {
                        versao = file[i];
                    }
                }

                if (versao != "")
                    new Form_Descompactando().DescompactarExe(versao);
            }
        }

        private void btn_Eco_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\ecosis\windows\eco.exe"))
                Process.Start(@"C:\ecosis\windows\eco.exe");
            else
                MessageBox.Show("Arquivo não encontrado, verifique..", "Aviso..");
        }

        private void btn_NFe_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\ecosis\DFE\DFeMonitor.exe"))
                Process.Start(@"C:\ecosis\DFE\DFeMonitor.exe");
            else
                MessageBox.Show("Arquivo não encontrado, verifique..", "Aviso..");
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            Form_Atualizar n = new Form_Atualizar();
            n.DesktopLocation = new Point(this.DesktopLocation.X - n.Width, this.DesktopLocation.Y);
            n.Show();
        }

        private void pnl_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            offset = e.Location;
        }

        private void pnl_Menu_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            if (this.DesktopLocation.X > Screen.PrimaryScreen.Bounds.Width - this.Size.Width)
            {
                this.DesktopLocation = new Point(Screen.PrimaryScreen.Bounds.Width - this.Size.Width, this.DesktopLocation.Y);
            }
            if (this.DesktopLocation.X < 0)
            {
                this.DesktopLocation = new Point(0, this.DesktopLocation.Y);
            }
            if (this.DesktopLocation.Y > Screen.PrimaryScreen.Bounds.Height - this.Size.Height)
            {
                this.DesktopLocation = new Point(this.DesktopLocation.X, Screen.PrimaryScreen.Bounds.Height - this.Size.Height);
            }
            if (this.DesktopLocation.Y < 0)
            {
                this.DesktopLocation = new Point(this.DesktopLocation.X, 0);
            }
        }

        private void pnl_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point positionA = PointToScreen(e.Location);
                Location = new Point(positionA.X - offset.X, positionA.Y - offset.Y);
            }
        }

        private void Form_ForSped_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            if (e.KeyCode == Keys.F12)
                Process.Start(@"C:\ecosis\windows\eco.ini");
        }

        private void btn_EcoSpedAntigo_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\ecosis\windows\ecosped 1.3.exe"))
                Process.Start(@"C:\ecosis\windows\ecosped 1.3.exe");
            else
                MessageBox.Show("Arquivo não encontrado, verifique..", "Aviso..");
        }

        public string CapturaPastaBanco()
        {
            var caminhoBanco = string.Empty;

            StreamReader rd = new StreamReader(@"C:\ecosis\windows\eco.ini");

            while (!rd.EndOfStream)
            {
                var linha = rd.ReadLine();
                if (linha.Length > 5)
                    if (linha.ToLower().Substring(0, 6) == "dados=")
                    {
                        caminhoBanco = linha.ToLower().Replace("dados=", "");
                    }
            }
            rd.Close();

            var parts = caminhoBanco.Split('\\');

            lb_Pasta.Text = parts[parts.Length - 2].ToUpper();

            return caminhoBanco;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            Form_MudarVersao frm = new Form_MudarVersao(_versao, stConect);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _versao = frm._versao;
                lbVersaoexe.Text = "Versão exe:    " + _versao;
                BuscarExecutavel();
            }
        }
    }
}

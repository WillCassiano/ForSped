using SharpCompress.Readers;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSPED
{
    public partial class Form_Atualizar : Form
    {
        public Form_Atualizar()
        {
            InitializeComponent();
        }

        public Form_Atualizar(Form_ForSped _frm)
        {
            _Frm = _frm;
            InitializeComponent();
        }

        Form_ForSped _Frm;

        Config c = new Config();
        FileInfo[] ecoAtualiza;
        FileInfo[] executaveis;
        FileInfo[] atualizadores;

        private void Form_Atualizar_Load(object sender, EventArgs e)
        {
            list_AtualizarBanco.Items.Clear();
            string[] dr = Directory.GetFiles(@"C:\ecosis\windows");
            string[] arquivo = new string[dr.Length];
            FileInfo leitor;
            int count = 0;
            for (int i = 0; i < dr.Length; i++)
            {
                leitor = new FileInfo(dr[i]);
                if (leitor.Name.Length > 8)
                    if (leitor.Name.Substring(0, 9).ToUpper() == "ECOUPDATE" && leitor.Extension == ".exe")
                    {
                        arquivo[count] = leitor.FullName;
                        count++;
                    }
            }

            // EcoAtualiza
            ecoAtualiza = new FileInfo[count];
            for (int x = 0; x < count; x++)
            {
                ecoAtualiza[x] = new FileInfo(arquivo[x]);
                list_AtualizarBanco.Items.Add(ecoAtualiza[x].Name);
            }
            CarregaExe();
            CarregaAtualizadores();
        }

        private void list_Atualizar_DoubleClick(object sender, EventArgs e)
        {
            if (list_AtualizarBanco.SelectedIndex > -1)
                Process.Start(ecoAtualiza[list_AtualizarBanco.SelectedIndex].FullName);
        }

        private void list_Atualizar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (list_AtualizarBanco.SelectedIndex > -1)
                    Process.Start(ecoAtualiza[list_AtualizarBanco.SelectedIndex].FullName);
        }

        private void Form_Atualizar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        public void CarregaExe()
        {
            list_AtualizarExecutavel.Items.Clear();
            if (Directory.Exists(c.pathExe))
            {
                string[] dr = Directory.GetFiles(c.pathExe);
                string[] arquivo = new string[dr.Length];
                FileInfo leitor;
                int count = 0;
                for (int i = 0; i < dr.Length; i++)
                {
                    leitor = new FileInfo(dr[i]);
                    if (leitor.Name.Length > 2)
                        if (leitor.Name.Substring(0, 3).ToUpper() == "ECO" && (leitor.Extension == ".rar" || leitor.Extension == ".zip"))
                        {
                            arquivo[count] = leitor.FullName;
                            count++;
                        }
                }

                // Executaveis
                executaveis = new FileInfo[count];
                for (int x = 0; x < count; x++)
                {
                    executaveis[x] = new FileInfo(arquivo[x]);
                    list_AtualizarExecutavel.Items.Add(executaveis[x].Name);
                }
            }
            else
                MessageBox.Show("Pasta para Executaveis não encontrada", "Aviso");
        }

        public void CarregaAtualizadores()
        {
            list_AtualizarSistema.Items.Clear();
            if (Directory.Exists(c.pathAtualizadores))
            {
                string[] dr = Directory.GetFiles(c.pathAtualizadores);
                string[] arquivo = new string[dr.Length];
                FileInfo leitor;
                int count = 0;
                for (int i = 0; i < dr.Length; i++)
                {
                    leitor = new FileInfo(dr[i]);
                    if (leitor.Name.Length > 10)
                        if (leitor.Name.Substring(0, 11).ToUpper() == "ECOATUALIZA" && leitor.Extension == ".exe")
                        {
                            arquivo[count] = leitor.FullName;
                            count++;
                        }
                }

                // Atualizadores
                atualizadores = new FileInfo[count];
                for (int x = 0; x < count; x++)
                {
                    atualizadores[x] = new FileInfo(arquivo[x]);
                    list_AtualizarSistema.Items.Add(atualizadores[x].Name);
                }
            }
            else
                MessageBox.Show("Pasta para Sistemas não encontrada", "Aviso");
        }

        private void list_AtualizarSistema_DoubleClick(object sender, EventArgs e)
        {
            if (list_AtualizarSistema.SelectedIndex > -1)
                Process.Start(atualizadores[list_AtualizarSistema.SelectedIndex].FullName);
        }

        private void list_AtualizarSistema_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (list_AtualizarSistema.SelectedIndex > -1)
                    Process.Start(atualizadores[list_AtualizarSistema.SelectedIndex].FullName);
        }

        private void list_AtualizarExecutavel_DoubleClick(object sender, EventArgs e)
        {
            if (list_AtualizarExecutavel.SelectedIndex <= 0) return;
            var fileName = executaveis[list_AtualizarExecutavel.SelectedIndex].FullName;
            new Form_Descompactando().DescompactarExe(fileName);
            Close();
        }

        

        private void list_AtualizarExecutavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (list_AtualizarExecutavel.SelectedIndex > -1)
                {
                    var fileName = executaveis[list_AtualizarExecutavel.SelectedIndex].FullName;
                    new Form_Descompactando().DescompactarExe(fileName);
                    Close();
                }
        }

        private void caminhoParaExeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                if (f.SelectedPath != "" || f.SelectedPath != null)
                {
                    c.pathExe = f.SelectedPath;
                    c.Save();
                    CarregaExe();
                }
        }

        private void caminhoParaAtualizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                if (f.SelectedPath != "" || f.SelectedPath != null)
                {
                    c.pathAtualizadores = f.SelectedPath;
                    c.Save();
                    CarregaAtualizadores();
                }
        }
    }
}

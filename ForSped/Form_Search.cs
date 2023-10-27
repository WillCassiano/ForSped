using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace ForSPED
{
    public partial class Form_Search : Form
    {
        public Form_Search(Form_ForSped _form)
        {
            _Frm = _form;
            InitializeComponent();
        }

        Form_ForSped _Frm;
        DirectoryInfo[] dr;
        Config _config = new Config();

        private void Form_Search_Load(object sender, EventArgs e)
        {
            CarregarDatabases();
        }

        private void CarregarDatabases()
        {
            listViewDatabases.Items.Clear();
            string[] drSt = Directory.GetDirectories(_config.pathBases);
            dr = new DirectoryInfo[drSt.Length];

            for (int i = 0; i < drSt.Length; i++)
            {
                dr[i] = new DirectoryInfo(drSt[i]);
                //list_Directory.Items.Add(dr[i].Name);

                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = dr[i].Name;

                var files = dr[i].GetFiles("ecodados.eco");
                listViewItem.SubItems.AddRange(files.Select(x => x.Name).ToArray());

                listViewItem.UseItemStyleForSubItems = true;

                foreach (ListViewSubItem item in listViewItem.SubItems)
                {
                    item.Font = new System.Drawing.Font(FontFamily.GenericMonospace, 8f, FontStyle.Italic);
                }

                listViewDatabases.Items.Add(listViewItem);
            }
        }

        private void list_Directory_DoubleClick(object sender, EventArgs e)
        {
            Conf.Alterar(dr[listViewDatabases.SelectedItems[0].Index].FullName, @"C:\ecosis\windows\eco.ini");
            Conf.Alterar(dr[listViewDatabases.SelectedItems[0].Index].FullName, @"C:\ecosis\windows\ecosped.ini", true);
            _Frm.CapturaPastaBanco();
            _Frm.InformacoesBanco();
            Close();
        }

        private void Form_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _Frm.CapturaPastaBanco();
                _Frm.InformacoesBanco();
                Close();
            }
        }

        private void list_Directory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                list_Directory_DoubleClick(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _config.pathBases = dlg.SelectedPath;
                _config.Save();

                CarregarDatabases();
            }
        }
    }
}

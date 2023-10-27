using SharpCompress.Readers;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSPED
{
    public partial class Form_Descompactando : Form
    {
        public Form_Descompactando()
        {
            InitializeComponent();
        }

        private void Form_Descompactando_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        public async void DescompactarExe(string filePath)
        {
            try
            {
                Show();
                var fileName = new FileInfo(filePath).Name;
                lblVersao.Text = $"Versão: {fileName}";

                Task task = new Task(new Action(() =>
                {
                    using (Stream stream = File.OpenRead(filePath))
                    {
                        using (var reader = ReaderFactory.Open(stream))
                        {
                            while (reader.MoveToNextEntry())
                            {
                                if (!reader.Entry.IsDirectory && reader.Entry.Key.ToLower().Contains("eco.exe"))
                                {
                                    reader.WriteEntryToFile(@"C:\ecosis\windows\eco.exe", new SharpCompress.Common.ExtractionOptions
                                    {
                                        ExtractFullPath = true,
                                        Overwrite = true
                                    });

                                    this.Invoke(new Action(() => { Close(); }));
                                }
                            }
                        }
                    }

                }));

                task.Start();

                await task;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Close(); }
        }
    }
}

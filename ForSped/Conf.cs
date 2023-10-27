using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ForSPED
{
    class Conf
    {
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        // Métodos..

        public static void Alterar(string diretorio, string ini)
        {
            if (Directory.Exists(diretorio) && File.Exists(ini))
            {
                StreamReader rd = new StreamReader(ini, Encoding.GetEncoding("iso-8859-1"));

                string linha, writer = "";

                while (!rd.EndOfStream)
                {
                    //Lendo linhas..
                    linha = rd.ReadLine();
                    if (linha.Length >= 8)
                    {
                        if (linha.Substring(0, 6).ToUpper() == "DADOS=")
                        {
                            linha = string.Format("dados=127.0.0.1:{0}\\ecodados.eco", diretorio);
                        }
                        if (linha.Substring(0, 8).ToUpper() == "DADOSNFE")
                        {
                            linha = string.Format("dadosnfe01=127.0.0.1:{0}\\econfe.eco", diretorio);
                        }
                    }

                    //Escritor..
                    writer += linha + "\r\n";
                }
                rd.Close();

                File.WriteAllText(ini, writer, Encoding.GetEncoding("iso-8859-1"));
            }
        }

        public static void Alterar(string diretorio, string ini, bool sped)
        {
            if (Directory.Exists(diretorio) && File.Exists(ini))
            {
                StreamReader rd = new StreamReader(ini, Encoding.GetEncoding("iso-8859-1"));

                string linha, writer = "";

                while (!rd.EndOfStream)
                {
                    //Lendo linhas..
                    linha = rd.ReadLine();
                    if (linha.Length >= 8)
                    {
                        if (linha.Substring(0, 6).ToUpper() == "DADOS=")
                        {
                            var dir = new DirectoryInfo(diretorio);
                            linha = string.Format("dados=127.0.0.1:{0}\\ecosped.eco", diretorio);
                        }
                        if (linha.ToUpper().Contains("CAMINHOSAIDA="))
                            linha = string.Format("CaminhoSaida={0}", diretorio);
                    }

                    //Escritor..
                    writer += linha + "\r\n";
                }
                rd.Close();

                File.WriteAllText(ini, writer, Encoding.GetEncoding("iso-8859-1"));
            }          
        }

        private void GetEmpresa()
        {

        }
    }
}

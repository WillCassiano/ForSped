using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime;

namespace ForSPED
{
    static class Program
    {
        //[DllImport("User32.dll")]
        //public static extern int SetForegroundWindow(IntPtr point);
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Process[] listProc = Process.GetProcessesByName("forsped");

            //if (listProc.Length == 0)
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Form_Descompactando("D:\\ECO\\_EcoExe\\eco 1.4.550.rar"));
            Application.Run(new Form_ForSped());
            //}
            //else
            //{
            //    MessageBox.Show("O Programa já está em execução!", 
            //                    "Aviso!", 
            //                    MessageBoxButtons.OK, 
            //                    MessageBoxIcon.Information);
            //Thread.Sleep(1000);
            //SetForegroundWindow(listProc[0].MainWindowHandle);
            //return;
            //}            
        }        
    }
}

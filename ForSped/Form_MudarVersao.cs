using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSPED
{
    public partial class Form_MudarVersao : Form
    {
        public string _versao;
        public string _stConect;
        public Form_MudarVersao(string versao, string stConect)
        {
            InitializeComponent();
            _stConect = stConect;
            _versao = versao;
            txtVersao.Text = _versao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _versao = txtVersao.Text;

            var con = new FbConnection(_stConect);
            var sql = "update tgerlicenca set versao = @versao;";
            var command = new FbCommand(sql, con);
            command.Parameters.AddWithValue("versao", _versao);

            try
            {
                con.Open();
                command.ExecuteNonQuery();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con?.Close();
            }
        }

        private void txtVersao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
            }
        }
    }
}

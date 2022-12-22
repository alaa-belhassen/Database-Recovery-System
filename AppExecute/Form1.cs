using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExecute
{
    public partial class FrmExecute : Form
    {
        public FrmExecute()
        {
            InitializeComponent();
        }

        private void cmdFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmExecute_Load(object sender, EventArgs e)
        {
            cmdExecute.Enabled = false;
        }

        private void cmdOuvrir_Click(object sender, EventArgs e)
        {
            try
            {
                openFile.Filter = "Fichier SQL | *.sql";
                openFile.InitialDirectory = "C:\\Users\\msi\\Downloads";
                openFile.ShowDialog();
                txtFile.Text = openFile.FileName;
                if (!String.IsNullOrEmpty(txtFile.Text))
                {
                    cmdExecute.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur " + ex.Message);
            }
            
           
        }

        private void txtFile_ChangeUICues(object sender, UICuesEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFile.Text))
            {
                cmdExecute.Enabled = true;
            }
        }

        


        private void cmdExecute_Click(object sender, EventArgs e)
        {
            // postgresql://postgres:data2010.@localhost/LCS";
            // "dbname=dbname user=user password=password host=host"

            string cmd=" -a -q -f ";
            cmd += "\"" + txtFile.Text + "\" postgresql://postgres:alaa@localhost:5433";
            try
            {
                var str=ExecuteExtension.executeCommand("psql", cmd);
                toolStripStatusLabel1.Text = str;
            }
            catch (Exception ex)
            {

                toolStripStatusLabel1.Text = ex.Message;
            }


        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

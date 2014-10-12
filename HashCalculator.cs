using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashCalculator
{
    public partial class HashCalculator : Form
    {
        const string DefaultHashCheck = "Enter hash check value here";

        public HashCalculator()
        {
            InitializeComponent();
        }

        private void HashCalculator_Load(object sender, EventArgs e)
        {
            tbHashCheck.ForeColor = Color.LightGray;
            tbHashCheck.Text = DefaultHashCheck;
            this.tbHashCheck.Leave += new System.EventHandler(this.tbHashCheck_Leave);
            this.tbHashCheck.Enter += new System.EventHandler(this.tbHashCheck_Enter);
        }
        
        // TODO  Look into changing the Select File to work the same way as the Select Folder 
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a File";
            openFileDialog1.InitialDirectory = "C:";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.Stream stream;
            stream = openFileDialog1.OpenFile();
            tbFileName.Text = openFileDialog1.FileName;
            stream.Close();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Choose a Folder";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result =  folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbFileName.Text = folderBrowserDialog1.SelectedPath;
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        // TODO Implement md5 folder hash calculating
        private void btnCalculateMd5_Click(object sender, EventArgs e)
        {
            Hash md5Hash = new Hash();
            String md5HashValue;
            md5HashValue = md5Hash.getMd5Hash(tbFileName.Text);
            tbHashValue.Text = md5HashValue;
            CalculateStatus();
        }

        //TODO Implement sha1 folder hash calculating
        private void btnCalculateSha1_Click(object sender, EventArgs e)
        {
            Hash sha1Hash = new Hash();
            String sha1HashValue;
            sha1HashValue = sha1Hash.getSha1Hash(tbFileName.Text);
            tbHashValue.Text = sha1HashValue;
            CalculateStatus();
        }

        private void tbHashCheck_Leave(object sender, EventArgs e)
        {
            if (tbHashCheck.Text.Length == 0)
            {
                tbHashCheck.Text = DefaultHashCheck;
                tbHashCheck.ForeColor = Color.LightGray;
                lblStatus.Text = String.Empty;
            }
            else
            {
                CalculateStatus();
            }
        }

        private void tbHashCheck_Enter(object sender, EventArgs e)
        {
            if (tbHashCheck.Text == DefaultHashCheck)
            {
                tbHashCheck.Text = "";
                tbHashCheck.ForeColor = Color.Black;
            }
        }

        private void CalculateStatus()
        {
            if (tbHashValue.Text.Length > 0 && tbHashCheck.Text != DefaultHashCheck && tbHashCheck.Text.Length > 0)
            {
                if (tbHashValue.Text == tbHashCheck.Text)
                {
                    lblStatus.Text = "Match";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "No Match";
                    lblStatus.ForeColor = Color.Red;                       
                }
            }
            else
            {
                lblStatus.Text = String.Empty;
            } 
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

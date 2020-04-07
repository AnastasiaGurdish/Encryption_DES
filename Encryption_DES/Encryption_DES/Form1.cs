using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Encryption_DES
{
    public partial class Form1 : Form
    {
        public delegate void ProgressInitHandler(object sender, ProgressInitArgs e);
        public delegate void ProgressEventHandler(object sender, ProgressEventArgs e);
        public static event ProgressEventHandler IncrementProgress;
        public static event ProgressInitHandler InitProgress;
        Cryptographer cryptographer = null;

        private bool IsFile = false;
        private bool IsEncryption = false;

        public Form1()
        {
            InitializeComponent();
            txtKey.MaxLength = 16;
        }

        public void DisableButtons()
        {
            btnFileDecrypt.Enabled = false;
            btnFileEncrypt.Enabled = false;
            btnFileSelect.Enabled = false;
        }

        public void EnableButtons()
        {
            btnFileDecrypt.Enabled = true;
            btnFileEncrypt.Enabled = true;
            btnFileSelect.Enabled = true;
        }

        private void StartProcess()
        {
            DisableButtons();
            this.StartSelectedProcess();
            if (IsFile == true)
            {
                MessageBox.Show(" File Encryption/Decryption is complete.");
                label7.Visible = true;
            }

            EnableButtons();
        }

        private void StartSelectedProcess()
        {

            if (IsEncryption == true)
            {
                if (IsFile == true)
                {
                    cryptographer = new Cryptographer(Algorithms.DES_File, IncrementProgress, InitProgress);
                    cryptographer.EncryptionStart(txtFile.Text.Replace("\\", "\\\\"), txtAlteredFile.Text.Replace("\\", "\\\\"), txtKey.Text.ToUpper());
                }
            }
            else
            {
                if (IsFile == true)
                {
                    cryptographer = new Cryptographer(Algorithms.DES_File, IncrementProgress, InitProgress);
                    cryptographer.DecryptionStart(txtFile.Text.Replace("\\", "\\\\"), txtAlteredFile.Text.Replace("\\", "\\\\"), txtKey.Text.ToUpper());
                }
            }
        }


        private void btnFileEncrypt_Click(object sender, EventArgs e)
        {
            if (!FileCheck() || !KeyCheck(txtKey.Text))
            {
                return;
            }
            IsFile = true;
            IsEncryption = true;
            StartProcess();
        }

        private void btnFileDecrypt_Click(object sender, EventArgs e)
        {
            if (!FileCheck() || !KeyCheck(txtKey.Text))
            {
                return;
            }
            IsFile = true;
            IsEncryption = false;
            StartProcess();
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            txtFile.Clear();
            txtAlteredFile.Clear();
            label7.Visible = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
                txtAlteredFile.Text = openFileDialog1.FileName.Replace(".", "_1.");
            }
        }

        private bool FileCheck()
        {
            if (txtFile.Text == "")
            {
                MessageBox.Show("Plaese select a file for encryption/decryption");
                return false;
            }

            return true;
        }

        private bool KeyCheck(string key)
        {
            if (key.Length == 16)
            {
                return true;
            }
            else
            {
                MessageBox.Show("The key is must be 16-HexDecimal Length for DES algorithm");
                return false;
            }
        }
    }
}

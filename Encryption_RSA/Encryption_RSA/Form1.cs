using System;
using System.Numerics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Encryption_RSA
{
    public partial class Form1 : Form
    {
        private bool IsFile = false;
        private bool IsEncryption = false;
        FileDialog F = new FileDialog();
        List<BigInteger> result;
        string DescrpText;
        string textFromFile;

        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Шифрование/Дешифрование файла успешно выполнено!");
            }
            EnableButtons();
        }

        private void StartSelectedProcess()
        {
            if (IsEncryption == true)
            {
                if (IsFile == true)
                {
                    result = RSA.EncriptionRSAMethod(textFromFile, RSA.GetPublicKey(), RSA.GetN());
                    F.SaveEncriptFile(txtAlteredFile.Text, result);
                }
            }
            else
            {
                if (IsFile == true)
                {
                    DescrpText = RSA.DecriptionRSAMethod(result, RSA.GetPrivateKey(), RSA.GetN());
                    F.SaveDecriptFile(txtAlteredFile.Text, DescrpText);
                }
            }
        }

        private void btnFileEncrypt_Click_1(object sender, EventArgs e)
        {
            if (!FileCheck())
            {
                return;
            }
            IsFile = true;
            IsEncryption = true;
            txtAlteredFile.Text = F.FilePath.Replace(".", "_Encrypt.");
            StartProcess();
        }

        private void btnFileDecrypt_Click_1(object sender, EventArgs e)
        {
            if (!FileCheck())
            {
                return;
            }
            IsFile = true;
            IsEncryption = false;
            txtAlteredFile.Text = F.FilePath.Replace("_Encrypt.", "_Decrypt.");
            StartProcess();
        }

        private void btnFileSelect_Click_1(object sender, EventArgs e)
        {
            txtFile.Clear();
            txtAlteredFile.Clear();
            F.OpenFile();
            textFromFile = F.Readytext;
            txtFile.Text = F.FilePath;
            txtAlteredFile.Text = F.FilePath.Replace(".", "_new.");

            if (!RSA.GetKeysAndN(out BigInteger publicKey, out BigInteger privateKey))
            {
                MessageBox.Show("Ошибка: не удалось сгенерировать простые числа. Попробуйте снова!");
            }

            primeNumber1.Text = "" + RSA.GetP();
            primeNumber2.Text = "" + RSA.GetQ();
            nInput.Text = "" + RSA.GetN();
            elerFunc.Text = "" + RSA.GetFn();
            PublicKey.Text = "" + RSA.GetPublicKey();
            PrivateKey.Text = "" + RSA.GetPrivateKey();
        }

        private bool FileCheck()
        {
            if (txtFile.Text == "")
            {
                MessageBox.Show("Сперва выберите файл!");
                return false;
            }

            return true;
        }
    }
}

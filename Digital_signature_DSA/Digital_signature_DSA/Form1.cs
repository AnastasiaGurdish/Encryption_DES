using System;
using System.IO;
using System.Numerics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Digital_signature_DSA
{
    public partial class Form1 : Form
    {
        private bool IsFile = false;
        private bool IsSignature = false;
        FileDialog F = new FileDialog();
        string textFromFile;
        List<string> result;
        string hash;
        string checkSignature;

        public Form1()
        {
            InitializeComponent();
        }

        public void DisableButtons()
        {
            btnSignature.Enabled = false;
            bttnCheckAuthenticity.Enabled = false;
            btnFileSelect.Enabled = false;
        }

        public void EnableButtons()
        {
            btnSignature.Enabled = true;
            bttnCheckAuthenticity.Enabled = true;
            btnFileSelect.Enabled = true;
        }

        private void StartProcess()
        {
            DisableButtons();
            this.StartSelectedProcess();
            if (IsSignature == true)
            {
                MessageBox.Show("Подпись файла успешно выполнена!");
            }
            else
            {
                MessageBox.Show("Проверка подленности проведена успешно!");
            }
            EnableButtons();
        }

        private void StartSelectedProcess()
        {
            if (IsSignature == true)
            {
                if (IsFile == true)
                {
                    result = DigitalSignature.DigitalSignatureFunction(hash, DigitalSignature.GetE(), DigitalSignature.GetN());
                    F.SaveEncriptFile(txtAlteredFile.Text, result); //подпись документа
                }
            }
            else
            {
                if (IsFile == true)
                {
                    checkSignature = DigitalSignature.CheckAuthenticity(result, DigitalSignature.GetD(), DigitalSignature.GetN());
                    hash = textFromFile.GetHashCode().ToString();
                    if (checkSignature.Equals(hash))
                        MessageBox.Show("Файл подлинный. Подпись верна.");
                    else
                        MessageBox.Show("Внимание! Файл НЕ подлинный!!!");
                    //F.SaveDecriptFile(txtAlteredFile.Text, checkSignature); // проверка подленности
                }
            }
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            txtFile.Clear();
            txtAlteredFile.Clear();
            F.OpenFile();
            textFromFile = F.Readytext;
            txtFile.Text = F.FilePath;
            txtAlteredFile.Text = F.FilePath.Replace(".", "_Signature.");
        }

        private void btnSignature_Click(object sender, EventArgs e)
        {
            if(!FileCheck())
            {
                return;
            }
            IsFile = true;
            IsSignature = true;
            hash = textFromFile.GetHashCode().ToString();

            if (!DigitalSignature.GetKeysAndN())
            {
                MessageBox.Show("Ошибка: не удалось сгенерировать простые числа. Попробуйте снова!");
                return;
            }
            primeNumber1.Text = "" + DigitalSignature.GetP();
            primeNumber2.Text = "" + DigitalSignature.GetQ();
            dInput.Text = "" + DigitalSignature.GetD();
            nInput.Text = "" + DigitalSignature.GetN();
            StartProcess();
        }

        private void bttnCheckAuthenticity_Click(object sender, EventArgs e)
        {
            if (!FileCheck())
            {
                return;
            }
            IsFile = true;
            IsSignature = false;
            StartProcess();
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

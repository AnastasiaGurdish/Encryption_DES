namespace Encryption_RSA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.txtAlteredFile = new System.Windows.Forms.TextBox();
            this.primeNumber1 = new System.Windows.Forms.TextBox();
            this.primeNumber2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.elerFunc = new System.Windows.Forms.TextBox();
            this.nInput = new System.Windows.Forms.TextBox();
            this.btnFileDecrypt = new System.Windows.Forms.Button();
            this.btnFileEncrypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PrivateKey = new System.Windows.Forms.TextBox();
            this.PublicKey = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Алгоритм RSA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Шифрование и дешифрование для файлов :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Файл:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label4.Location = new System.Drawing.Point(29, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя нового файла: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label5.Location = new System.Drawing.Point(29, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "P:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label6.Location = new System.Drawing.Point(225, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Функция Эйлера F(N):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label7.Location = new System.Drawing.Point(29, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "N:";
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFile.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.txtFile.Location = new System.Drawing.Point(33, 103);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(220, 28);
            this.txtFile.TabIndex = 8;
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFileSelect.FlatAppearance.BorderSize = 0;
            this.btnFileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSelect.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFileSelect.Location = new System.Drawing.Point(273, 103);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(132, 28);
            this.btnFileSelect.TabIndex = 9;
            this.btnFileSelect.Text = "Загрузить файл";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click_1);
            // 
            // txtAlteredFile
            // 
            this.txtAlteredFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAlteredFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlteredFile.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.txtAlteredFile.Location = new System.Drawing.Point(33, 166);
            this.txtAlteredFile.Name = "txtAlteredFile";
            this.txtAlteredFile.Size = new System.Drawing.Size(370, 28);
            this.txtAlteredFile.TabIndex = 10;
            // 
            // primeNumber1
            // 
            this.primeNumber1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.primeNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.primeNumber1.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.primeNumber1.Location = new System.Drawing.Point(32, 239);
            this.primeNumber1.Name = "primeNumber1";
            this.primeNumber1.Size = new System.Drawing.Size(175, 28);
            this.primeNumber1.TabIndex = 11;
            // 
            // primeNumber2
            // 
            this.primeNumber2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.primeNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.primeNumber2.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.primeNumber2.Location = new System.Drawing.Point(228, 239);
            this.primeNumber2.Name = "primeNumber2";
            this.primeNumber2.Size = new System.Drawing.Size(175, 28);
            this.primeNumber2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label8.Location = new System.Drawing.Point(224, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Q:";
            // 
            // elerFunc
            // 
            this.elerFunc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.elerFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elerFunc.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.elerFunc.Location = new System.Drawing.Point(228, 306);
            this.elerFunc.Name = "elerFunc";
            this.elerFunc.Size = new System.Drawing.Size(175, 28);
            this.elerFunc.TabIndex = 15;
            // 
            // nInput
            // 
            this.nInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nInput.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.nInput.Location = new System.Drawing.Point(32, 306);
            this.nInput.Name = "nInput";
            this.nInput.Size = new System.Drawing.Size(175, 28);
            this.nInput.TabIndex = 14;
            // 
            // btnFileDecrypt
            // 
            this.btnFileDecrypt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFileDecrypt.FlatAppearance.BorderSize = 0;
            this.btnFileDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDecrypt.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.btnFileDecrypt.Location = new System.Drawing.Point(228, 430);
            this.btnFileDecrypt.Name = "btnFileDecrypt";
            this.btnFileDecrypt.Size = new System.Drawing.Size(175, 28);
            this.btnFileDecrypt.TabIndex = 17;
            this.btnFileDecrypt.Text = "Дешифровать";
            this.btnFileDecrypt.UseVisualStyleBackColor = false;
            this.btnFileDecrypt.Click += new System.EventHandler(this.btnFileDecrypt_Click_1);
            // 
            // btnFileEncrypt
            // 
            this.btnFileEncrypt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFileEncrypt.FlatAppearance.BorderSize = 0;
            this.btnFileEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileEncrypt.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.btnFileEncrypt.Location = new System.Drawing.Point(32, 430);
            this.btnFileEncrypt.Name = "btnFileEncrypt";
            this.btnFileEncrypt.Size = new System.Drawing.Size(175, 28);
            this.btnFileEncrypt.TabIndex = 16;
            this.btnFileEncrypt.Text = "Зашифровать";
            this.btnFileEncrypt.UseVisualStyleBackColor = false;
            this.btnFileEncrypt.Click += new System.EventHandler(this.btnFileEncrypt_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label10.Location = new System.Drawing.Point(29, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Открытый ключ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label11.Location = new System.Drawing.Point(225, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Закрытый ключ:";
            // 
            // PrivateKey
            // 
            this.PrivateKey.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrivateKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrivateKey.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.PrivateKey.Location = new System.Drawing.Point(228, 373);
            this.PrivateKey.Name = "PrivateKey";
            this.PrivateKey.Size = new System.Drawing.Size(175, 28);
            this.PrivateKey.TabIndex = 22;
            // 
            // PublicKey
            // 
            this.PublicKey.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PublicKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PublicKey.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.PublicKey.Location = new System.Drawing.Point(32, 373);
            this.PublicKey.Name = "PublicKey";
            this.PublicKey.Size = new System.Drawing.Size(175, 28);
            this.PublicKey.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(432, 490);
            this.Controls.Add(this.PrivateKey);
            this.Controls.Add(this.PublicKey);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnFileDecrypt);
            this.Controls.Add(this.btnFileEncrypt);
            this.Controls.Add(this.elerFunc);
            this.Controls.Add(this.nInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.primeNumber2);
            this.Controls.Add(this.primeNumber1);
            this.Controls.Add(this.txtAlteredFile);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(460, 600);
            this.MinimumSize = new System.Drawing.Size(450, 467);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.TextBox txtAlteredFile;
        private System.Windows.Forms.TextBox primeNumber1;
        private System.Windows.Forms.TextBox primeNumber2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox elerFunc;
        private System.Windows.Forms.TextBox nInput;
        private System.Windows.Forms.Button btnFileDecrypt;
        private System.Windows.Forms.Button btnFileEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PrivateKey;
        private System.Windows.Forms.TextBox PublicKey;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


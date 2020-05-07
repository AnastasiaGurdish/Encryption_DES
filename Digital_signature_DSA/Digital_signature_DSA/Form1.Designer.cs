namespace Digital_signature_DSA
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
            this.txtAlteredFile = new System.Windows.Forms.TextBox();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.primeNumber2 = new System.Windows.Forms.TextBox();
            this.primeNumber1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSignature = new System.Windows.Forms.Button();
            this.bttnCheckAuthenticity = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цифровая подпись DSA";
            // 
            // txtAlteredFile
            // 
            this.txtAlteredFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAlteredFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlteredFile.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.txtAlteredFile.Location = new System.Drawing.Point(32, 127);
            this.txtAlteredFile.Name = "txtAlteredFile";
            this.txtAlteredFile.Size = new System.Drawing.Size(399, 28);
            this.txtAlteredFile.TabIndex = 15;
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFileSelect.FlatAppearance.BorderSize = 0;
            this.btnFileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSelect.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFileSelect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFileSelect.Location = new System.Drawing.Point(267, 64);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(164, 28);
            this.btnFileSelect.TabIndex = 14;
            this.btnFileSelect.Text = "Исходный файл";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFile.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.txtFile.Location = new System.Drawing.Point(32, 64);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(217, 28);
            this.txtFile.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label4.Location = new System.Drawing.Point(28, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Имя нового файла: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Файл:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label8.Location = new System.Drawing.Point(252, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Q:";
            // 
            // primeNumber2
            // 
            this.primeNumber2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.primeNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.primeNumber2.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.primeNumber2.Location = new System.Drawing.Point(256, 220);
            this.primeNumber2.Name = "primeNumber2";
            this.primeNumber2.Size = new System.Drawing.Size(175, 28);
            this.primeNumber2.TabIndex = 19;
            // 
            // primeNumber1
            // 
            this.primeNumber1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.primeNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.primeNumber1.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.primeNumber1.Location = new System.Drawing.Point(32, 220);
            this.primeNumber1.Name = "primeNumber1";
            this.primeNumber1.Size = new System.Drawing.Size(175, 28);
            this.primeNumber1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label5.Location = new System.Drawing.Point(29, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "P:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label6.Location = new System.Drawing.Point(29, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Пара простых чисел:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label7.Location = new System.Drawing.Point(29, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Секретный ключ:";
            // 
            // nInput
            // 
            this.nInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nInput.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.nInput.Location = new System.Drawing.Point(256, 315);
            this.nInput.Name = "nInput";
            this.nInput.Size = new System.Drawing.Size(175, 28);
            this.nInput.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label9.Location = new System.Drawing.Point(253, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "N:";
            // 
            // dInput
            // 
            this.dInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dInput.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.dInput.Location = new System.Drawing.Point(32, 315);
            this.dInput.Name = "dInput";
            this.dInput.Size = new System.Drawing.Size(175, 28);
            this.dInput.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label10.Location = new System.Drawing.Point(29, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "D:";
            // 
            // btnSignature
            // 
            this.btnSignature.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSignature.FlatAppearance.BorderSize = 0;
            this.btnSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignature.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.btnSignature.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSignature.Location = new System.Drawing.Point(32, 370);
            this.btnSignature.Name = "btnSignature";
            this.btnSignature.Size = new System.Drawing.Size(175, 66);
            this.btnSignature.TabIndex = 27;
            this.btnSignature.Text = "Подписать \r\nдокумент";
            this.btnSignature.UseVisualStyleBackColor = false;
            this.btnSignature.Click += new System.EventHandler(this.btnSignature_Click);
            // 
            // bttnCheckAuthenticity
            // 
            this.bttnCheckAuthenticity.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttnCheckAuthenticity.FlatAppearance.BorderSize = 0;
            this.bttnCheckAuthenticity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCheckAuthenticity.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.bttnCheckAuthenticity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnCheckAuthenticity.Location = new System.Drawing.Point(256, 370);
            this.bttnCheckAuthenticity.Name = "bttnCheckAuthenticity";
            this.bttnCheckAuthenticity.Size = new System.Drawing.Size(175, 66);
            this.bttnCheckAuthenticity.TabIndex = 28;
            this.bttnCheckAuthenticity.Text = "Проверить\r\nподлинность";
            this.bttnCheckAuthenticity.UseVisualStyleBackColor = false;
            this.bttnCheckAuthenticity.Click += new System.EventHandler(this.bttnCheckAuthenticity_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 462);
            this.Controls.Add(this.bttnCheckAuthenticity);
            this.Controls.Add(this.btnSignature);
            this.Controls.Add(this.dInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.primeNumber2);
            this.Controls.Add(this.primeNumber1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlteredFile);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlteredFile;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox primeNumber2;
        private System.Windows.Forms.TextBox primeNumber1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSignature;
        private System.Windows.Forms.Button bttnCheckAuthenticity;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


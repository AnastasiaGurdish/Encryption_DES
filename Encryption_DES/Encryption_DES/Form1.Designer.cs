namespace Encryption_DES
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
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.btnFileEncrypt = new System.Windows.Forms.Button();
            this.btnFileDecrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlteredFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cryptography Algorithm";
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFileSelect.FlatAppearance.BorderSize = 0;
            this.btnFileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSelect.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFileSelect.Location = new System.Drawing.Point(287, 111);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(120, 28);
            this.btnFileSelect.TabIndex = 2;
            this.btnFileSelect.Text = "Upload file";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // btnFileEncrypt
            // 
            this.btnFileEncrypt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFileEncrypt.FlatAppearance.BorderSize = 0;
            this.btnFileEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileEncrypt.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.btnFileEncrypt.Location = new System.Drawing.Point(36, 330);
            this.btnFileEncrypt.Name = "btnFileEncrypt";
            this.btnFileEncrypt.Size = new System.Drawing.Size(175, 28);
            this.btnFileEncrypt.TabIndex = 3;
            this.btnFileEncrypt.Text = "Encryption";
            this.btnFileEncrypt.UseVisualStyleBackColor = false;
            this.btnFileEncrypt.Click += new System.EventHandler(this.btnFileEncrypt_Click);
            // 
            // btnFileDecrypt
            // 
            this.btnFileDecrypt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFileDecrypt.FlatAppearance.BorderSize = 0;
            this.btnFileDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDecrypt.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.btnFileDecrypt.Location = new System.Drawing.Point(231, 330);
            this.btnFileDecrypt.Name = "btnFileDecrypt";
            this.btnFileDecrypt.Size = new System.Drawing.Size(175, 28);
            this.btnFileDecrypt.TabIndex = 4;
            this.btnFileDecrypt.Text = "Decryption";
            this.btnFileDecrypt.UseVisualStyleBackColor = false;
            this.btnFileDecrypt.Click += new System.EventHandler(this.btnFileDecrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encryption and Decryption for files :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "File:";
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFile.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.txtFile.Location = new System.Drawing.Point(36, 111);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(231, 28);
            this.txtFile.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label4.Location = new System.Drawing.Point(32, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Altered File Name : ";
            // 
            // txtAlteredFile
            // 
            this.txtAlteredFile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAlteredFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlteredFile.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.txtAlteredFile.Location = new System.Drawing.Point(36, 178);
            this.txtAlteredFile.Name = "txtAlteredFile";
            this.txtAlteredFile.Size = new System.Drawing.Size(370, 28);
            this.txtAlteredFile.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label5.Location = new System.Drawing.Point(32, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Key : ";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.Font = new System.Drawing.Font("Times New Roman", 11.78182F);
            this.txtKey.Location = new System.Drawing.Point(36, 247);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(370, 28);
            this.txtKey.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(43, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "The key is only allowed for Hex-Decimal( ex : 0123456789ABCDEF )";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.818182F);
            this.label7.Location = new System.Drawing.Point(67, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "To decrypt text, select a file with encrypted text";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(442, 423);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlteredFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFileDecrypt);
            this.Controls.Add(this.btnFileEncrypt);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button btnFileEncrypt;
        private System.Windows.Forms.Button btnFileDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlteredFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
    }
}



namespace HashCompare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbSHA512 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSHA256 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSHA1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMD5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.cbMD5 = new System.Windows.Forms.CheckBox();
            this.cbSHA1 = new System.Windows.Forms.CheckBox();
            this.cbSHA256 = new System.Windows.Forms.CheckBox();
            this.cbSHA512 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hash Compare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Path";
            // 
            // txbPath
            // 
            this.txbPath.Location = new System.Drawing.Point(97, 62);
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(683, 23);
            this.txbPath.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(786, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Original Hash";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(759, 23);
            this.textBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSHA512);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbSHA256);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbSHA1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbMD5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 207);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // txbSHA512
            // 
            this.txbSHA512.Enabled = false;
            this.txbSHA512.Location = new System.Drawing.Point(6, 169);
            this.txbSHA512.Name = "txbSHA512";
            this.txbSHA512.ReadOnly = true;
            this.txbSHA512.Size = new System.Drawing.Size(838, 23);
            this.txbSHA512.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "SHA-512";
            // 
            // txbSHA256
            // 
            this.txbSHA256.Enabled = false;
            this.txbSHA256.Location = new System.Drawing.Point(6, 125);
            this.txbSHA256.Name = "txbSHA256";
            this.txbSHA256.ReadOnly = true;
            this.txbSHA256.Size = new System.Drawing.Size(838, 23);
            this.txbSHA256.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "SHA-256";
            // 
            // txbSHA1
            // 
            this.txbSHA1.Enabled = false;
            this.txbSHA1.Location = new System.Drawing.Point(6, 81);
            this.txbSHA1.Name = "txbSHA1";
            this.txbSHA1.ReadOnly = true;
            this.txbSHA1.Size = new System.Drawing.Size(838, 23);
            this.txbSHA1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "SHA-1";
            // 
            // txbMD5
            // 
            this.txbMD5.Enabled = false;
            this.txbMD5.Location = new System.Drawing.Point(6, 37);
            this.txbMD5.Name = "txbMD5";
            this.txbMD5.ReadOnly = true;
            this.txbMD5.Size = new System.Drawing.Size(838, 23);
            this.txbMD5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "MD5";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 358);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(93, 358);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 8;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            // 
            // cbMD5
            // 
            this.cbMD5.AutoSize = true;
            this.cbMD5.Location = new System.Drawing.Point(18, 120);
            this.cbMD5.Name = "cbMD5";
            this.cbMD5.Size = new System.Drawing.Size(51, 19);
            this.cbMD5.TabIndex = 9;
            this.cbMD5.Text = "MD5";
            this.cbMD5.UseVisualStyleBackColor = true;
            // 
            // cbSHA1
            // 
            this.cbSHA1.AutoSize = true;
            this.cbSHA1.Location = new System.Drawing.Point(75, 120);
            this.cbSHA1.Name = "cbSHA1";
            this.cbSHA1.Size = new System.Drawing.Size(55, 19);
            this.cbSHA1.TabIndex = 10;
            this.cbSHA1.Text = "SHA1";
            this.cbSHA1.UseVisualStyleBackColor = true;
            // 
            // cbSHA256
            // 
            this.cbSHA256.AutoSize = true;
            this.cbSHA256.Location = new System.Drawing.Point(136, 120);
            this.cbSHA256.Name = "cbSHA256";
            this.cbSHA256.Size = new System.Drawing.Size(67, 19);
            this.cbSHA256.TabIndex = 11;
            this.cbSHA256.Text = "SHA256";
            this.cbSHA256.UseVisualStyleBackColor = true;
            // 
            // cbSHA512
            // 
            this.cbSHA512.AutoSize = true;
            this.cbSHA512.Location = new System.Drawing.Point(209, 120);
            this.cbSHA512.Name = "cbSHA512";
            this.cbSHA512.Size = new System.Drawing.Size(67, 19);
            this.cbSHA512.TabIndex = 12;
            this.cbSHA512.Text = "SHA512";
            this.cbSHA512.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 392);
            this.Controls.Add(this.cbSHA512);
            this.Controls.Add(this.cbSHA256);
            this.Controls.Add(this.cbSHA1);
            this.Controls.Add(this.cbMD5);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Compare";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbSHA512;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSHA256;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSHA1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMD5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.CheckBox cbMD5;
        private System.Windows.Forms.CheckBox cbSHA1;
        private System.Windows.Forms.CheckBox cbSHA256;
        private System.Windows.Forms.CheckBox cbSHA512;
    }
}


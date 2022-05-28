
namespace DuongHoangKhang_PhanHungPhat_RSA
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb = new System.Windows.Forms.ComboBox();
            this.txtplantext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcyphertext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.but_Decryption = new System.Windows.Forms.Button();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.butThongTin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Encryption";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Độ dài Key (bit)";
            // 
            // cbb
            // 
            this.cbb.FormattingEnabled = true;
            this.cbb.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048"});
            this.cbb.Location = new System.Drawing.Point(210, 13);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(75, 28);
            this.cbb.TabIndex = 3;
            // 
            // txtplantext
            // 
            this.txtplantext.BackColor = System.Drawing.Color.AliceBlue;
            this.txtplantext.ForeColor = System.Drawing.Color.Black;
            this.txtplantext.Location = new System.Drawing.Point(132, 78);
            this.txtplantext.Name = "txtplantext";
            this.txtplantext.Size = new System.Drawing.Size(453, 27);
            this.txtplantext.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plantext";
            // 
            // txtcyphertext
            // 
            this.txtcyphertext.BackColor = System.Drawing.Color.AliceBlue;
            this.txtcyphertext.ForeColor = System.Drawing.Color.Black;
            this.txtcyphertext.Location = new System.Drawing.Point(132, 147);
            this.txtcyphertext.Name = "txtcyphertext";
            this.txtcyphertext.Size = new System.Drawing.Size(453, 27);
            this.txtcyphertext.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cipher Text";
            // 
            // but_Decryption
            // 
            this.but_Decryption.Location = new System.Drawing.Point(447, 313);
            this.but_Decryption.Name = "but_Decryption";
            this.but_Decryption.Size = new System.Drawing.Size(138, 64);
            this.but_Decryption.TabIndex = 5;
            this.but_Decryption.Text = "Decryption";
            this.but_Decryption.UseVisualStyleBackColor = true;
            this.but_Decryption.Click += new System.EventHandler(this.but_Decryption_Click);
            // 
            // txtKetqua
            // 
            this.txtKetqua.BackColor = System.Drawing.Color.AliceBlue;
            this.txtKetqua.ForeColor = System.Drawing.Color.Black;
            this.txtKetqua.Location = new System.Drawing.Point(132, 213);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(453, 27);
            this.txtKetqua.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Decryption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(666, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 46);
            this.label5.TabIndex = 6;
            this.label5.Text = "RSA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(34, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(537, 12);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(160, 27);
            this.txtThongTin.TabIndex = 9;
            // 
            // butThongTin
            // 
            this.butThongTin.Location = new System.Drawing.Point(376, 12);
            this.butThongTin.Name = "butThongTin";
            this.butThongTin.Size = new System.Drawing.Size(121, 29);
            this.butThongTin.TabIndex = 10;
            this.butThongTin.Text = "Thông tin khóa";
            this.butThongTin.UseVisualStyleBackColor = true;
            this.butThongTin.Click += new System.EventHandler(this.butThongTin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butThongTin);
            this.Controls.Add(this.txtThongTin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.but_Decryption);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtcyphertext);
            this.Controls.Add(this.txtplantext);
            this.Controls.Add(this.cbb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Dương_Hoàng_Khang-Phan_Hùng_Phát";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb;
        private System.Windows.Forms.TextBox txtplantext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcyphertext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_Decryption;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Button butThongTin;
    }
}


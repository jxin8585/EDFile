namespace EDFile
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_browse = new System.Windows.Forms.Button();
            this.tb_inifile = new System.Windows.Forms.TextBox();
            this.btn_DESEncrypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_DESDecrypt = new System.Windows.Forms.Button();
            this.btn_RC4Decrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_out = new System.Windows.Forms.RichTextBox();
            this.tb_in = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_de = new System.Windows.Forms.Button();
            this.btn_en = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_RC4Encrypt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(12, 35);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "选择文件";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tb_inifile
            // 
            this.tb_inifile.Location = new System.Drawing.Point(92, 37);
            this.tb_inifile.Name = "tb_inifile";
            this.tb_inifile.Size = new System.Drawing.Size(347, 21);
            this.tb_inifile.TabIndex = 1;
            // 
            // btn_DESEncrypt
            // 
            this.btn_DESEncrypt.Location = new System.Drawing.Point(446, 21);
            this.btn_DESEncrypt.Name = "btn_DESEncrypt";
            this.btn_DESEncrypt.Size = new System.Drawing.Size(94, 23);
            this.btn_DESEncrypt.TabIndex = 2;
            this.btn_DESEncrypt.Text = "DES加密";
            this.btn_DESEncrypt.UseVisualStyleBackColor = true;
            this.btn_DESEncrypt.Click += new System.EventHandler(this.btn_DESEncrypt_Click);
            // 
            // btn_DESDecrypt
            // 
            this.btn_DESDecrypt.Location = new System.Drawing.Point(546, 21);
            this.btn_DESDecrypt.Name = "btn_DESDecrypt";
            this.btn_DESDecrypt.Size = new System.Drawing.Size(93, 23);
            this.btn_DESDecrypt.TabIndex = 3;
            this.btn_DESDecrypt.Text = "DES解密";
            this.btn_DESDecrypt.UseVisualStyleBackColor = true;
            this.btn_DESDecrypt.Click += new System.EventHandler(this.btn_DESDecrypt_Click);
            // 
            // btn_RC4Decrypt
            // 
            this.btn_RC4Decrypt.Location = new System.Drawing.Point(546, 49);
            this.btn_RC4Decrypt.Name = "btn_RC4Decrypt";
            this.btn_RC4Decrypt.Size = new System.Drawing.Size(93, 23);
            this.btn_RC4Decrypt.TabIndex = 4;
            this.btn_RC4Decrypt.Text = "RC4Base64解密";
            this.btn_RC4Decrypt.UseVisualStyleBackColor = true;
            this.btn_RC4Decrypt.Click += new System.EventHandler(this.btn_RC4Decrypt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_out);
            this.groupBox1.Controls.Add(this.tb_in);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_de);
            this.groupBox1.Controls.Add(this.btn_en);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 273);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文本加密";
            // 
            // tb_out
            // 
            this.tb_out.Location = new System.Drawing.Point(77, 136);
            this.tb_out.Name = "tb_out";
            this.tb_out.Size = new System.Drawing.Size(481, 96);
            this.tb_out.TabIndex = 13;
            this.tb_out.Text = "";
            // 
            // tb_in
            // 
            this.tb_in.Location = new System.Drawing.Point(77, 21);
            this.tb_in.Name = "tb_in";
            this.tb_in.Size = new System.Drawing.Size(481, 96);
            this.tb_in.TabIndex = 12;
            this.tb_in.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_de
            // 
            this.btn_de.Location = new System.Drawing.Point(359, 239);
            this.btn_de.Name = "btn_de";
            this.btn_de.Size = new System.Drawing.Size(49, 23);
            this.btn_de.TabIndex = 9;
            this.btn_de.Text = "解密";
            this.btn_de.UseVisualStyleBackColor = true;
            this.btn_de.Click += new System.EventHandler(this.btn_de_Click);
            // 
            // btn_en
            // 
            this.btn_en.Location = new System.Drawing.Point(187, 239);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(49, 23);
            this.btn_en.TabIndex = 6;
            this.btn_en.Text = "加密";
            this.btn_en.UseVisualStyleBackColor = true;
            this.btn_en.Click += new System.EventHandler(this.btn_en_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "输出文本：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入文本：";
            // 
            // btn_RC4Encrypt
            // 
            this.btn_RC4Encrypt.Location = new System.Drawing.Point(446, 49);
            this.btn_RC4Encrypt.Name = "btn_RC4Encrypt";
            this.btn_RC4Encrypt.Size = new System.Drawing.Size(94, 23);
            this.btn_RC4Encrypt.TabIndex = 6;
            this.btn_RC4Encrypt.Text = "RC4Base64加密";
            this.btn_RC4Encrypt.UseVisualStyleBackColor = true;
            this.btn_RC4Encrypt.Click += new System.EventHandler(this.btn_RC4Encrypt_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 371);
            this.Controls.Add(this.btn_RC4Encrypt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_RC4Decrypt);
            this.Controls.Add(this.btn_DESDecrypt);
            this.Controls.Add(this.btn_DESEncrypt);
            this.Controls.Add(this.tb_inifile);
            this.Controls.Add(this.btn_browse);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文本文件·加解密程序";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox tb_inifile;
        private System.Windows.Forms.Button btn_DESEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_DESDecrypt;
        private System.Windows.Forms.Button btn_RC4Decrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_de;
        private System.Windows.Forms.Button btn_en;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox tb_in;
        private System.Windows.Forms.RichTextBox tb_out;
        private System.Windows.Forms.Button btn_RC4Encrypt;
    }
}


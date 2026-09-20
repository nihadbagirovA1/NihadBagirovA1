namespace NihadA1
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
            splitContainer1 = new SplitContainer();
            txtLoginPass = new TextBox();
            btnLogin = new Button();
            txtLoginUser = new TextBox();
            label1 = new Label();
            txtRegSifre = new TextBox();
            txtRegEmail = new TextBox();
            txtRegSoyad = new TextBox();
            btnRegister = new Button();
            txtRegAd = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.InactiveCaption;
            splitContainer1.Panel1.Controls.Add(txtLoginPass);
            splitContainer1.Panel1.Controls.Add(btnLogin);
            splitContainer1.Panel1.Controls.Add(txtLoginUser);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.InactiveCaption;
            splitContainer1.Panel2.Controls.Add(txtRegSifre);
            splitContainer1.Panel2.Controls.Add(txtRegEmail);
            splitContainer1.Panel2.Controls.Add(txtRegSoyad);
            splitContainer1.Panel2.Controls.Add(btnRegister);
            splitContainer1.Panel2.Controls.Add(txtRegAd);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(679, 421);
            splitContainer1.SplitterDistance = 339;
            splitContainer1.TabIndex = 0;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Location = new Point(112, 136);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.PlaceholderText = "Şifrə";
            txtLoginPass.Size = new Size(125, 27);
            txtLoginPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(112, 331);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Daxil ol";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginUser
            // 
            txtLoginUser.Location = new Point(112, 87);
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.PlaceholderText = "İstifadəçi adı";
            txtLoginUser.Size = new Size(125, 27);
            txtLoginUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(146, 29);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Daxil ol";
            // 
            // txtRegSifre
            // 
            txtRegSifre.Location = new Point(73, 232);
            txtRegSifre.Name = "txtRegSifre";
            txtRegSifre.PlaceholderText = "Şifrə";
            txtRegSifre.Size = new Size(125, 27);
            txtRegSifre.TabIndex = 6;
            // 
            // txtRegEmail
            // 
            txtRegEmail.Location = new Point(73, 184);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.PlaceholderText = "Email";
            txtRegEmail.Size = new Size(125, 27);
            txtRegEmail.TabIndex = 5;
            // 
            // txtRegSoyad
            // 
            txtRegSoyad.Location = new Point(73, 136);
            txtRegSoyad.Name = "txtRegSoyad";
            txtRegSoyad.PlaceholderText = "Soyad";
            txtRegSoyad.Size = new Size(125, 27);
            txtRegSoyad.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(73, 331);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(141, 29);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Qeydiyyatdan keç";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button2_Click;
            // 
            // txtRegAd
            // 
            txtRegAd.Location = new Point(73, 87);
            txtRegAd.Name = "txtRegAd";
            txtRegAd.PlaceholderText = "Ad";
            txtRegAd.Size = new Size(125, 27);
            txtRegAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(103, 29);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Qeydiyyat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 421);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtLoginUser;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Button btnRegister;
        private TextBox txtRegAd;
        private TextBox txtLoginPass;
        private TextBox txtRegSifre;
        private TextBox txtRegEmail;
        private TextBox txtRegSoyad;
    }
}

namespace Ev_isi4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnTemizle = new Button();
            btnHesabla = new Button();
            txtQaliq = new TextBox();
            mtbMebleg = new MaskedTextBox();
            lblQaliq = new Label();
            lblMebleg = new Label();
            txtMuddet = new TextBox();
            lblMuddet = new Label();
            pbLogo = new PictureBox();
            lblCafe = new Label();
            panel2 = new Panel();
            txtHesab = new TextBox();
            lblHesab = new Label();
            btnYekunHesab = new Button();
            btnYenile = new Button();
            btnSil = new Button();
            lstSebet = new ListBox();
            lblSebet = new Label();
            lblMenu = new Label();
            pbTort = new PictureBox();
            pbKola = new PictureBox();
            pbLimonad = new PictureBox();
            pbBurger = new PictureBox();
            pbSendvic = new PictureBox();
            pbPizza = new PictureBox();
            pbRulet = new PictureBox();
            pbHotdog = new PictureBox();
            pbPecenye = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLimonad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSendvic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPizza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRulet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHotdog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPecenye).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnTemizle);
            panel1.Controls.Add(btnHesabla);
            panel1.Controls.Add(txtQaliq);
            panel1.Controls.Add(mtbMebleg);
            panel1.Controls.Add(lblQaliq);
            panel1.Controls.Add(lblMebleg);
            panel1.Controls.Add(txtMuddet);
            panel1.Controls.Add(lblMuddet);
            panel1.Controls.Add(pbLogo);
            panel1.Controls.Add(lblCafe);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 578);
            panel1.TabIndex = 0;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Red;
            btnTemizle.ForeColor = SystemColors.ButtonHighlight;
            btnTemizle.Location = new Point(25, 525);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(135, 35);
            btnTemizle.TabIndex = 9;
            btnTemizle.Text = "Təmizlə";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnHesabla
            // 
            btnHesabla.BackColor = Color.ForestGreen;
            btnHesabla.ForeColor = SystemColors.ButtonHighlight;
            btnHesabla.Location = new Point(25, 471);
            btnHesabla.Name = "btnHesabla";
            btnHesabla.Size = new Size(135, 35);
            btnHesabla.TabIndex = 8;
            btnHesabla.Text = "Hesabla";
            btnHesabla.UseVisualStyleBackColor = false;
            btnHesabla.Click += btnHesabla_Click;
            // 
            // txtQaliq
            // 
            txtQaliq.Location = new Point(24, 408);
            txtQaliq.Name = "txtQaliq";
            txtQaliq.Size = new Size(125, 27);
            txtQaliq.TabIndex = 7;
            // 
            // mtbMebleg
            // 
            mtbMebleg.Location = new Point(24, 329);
            mtbMebleg.Mask = "0000";
            mtbMebleg.Name = "mtbMebleg";
            mtbMebleg.Size = new Size(125, 27);
            mtbMebleg.TabIndex = 6;
            mtbMebleg.ValidatingType = typeof(int);
            // 
            // lblQaliq
            // 
            lblQaliq.AutoSize = true;
            lblQaliq.Location = new Point(25, 385);
            lblQaliq.Name = "lblQaliq";
            lblQaliq.Size = new Size(45, 20);
            lblQaliq.TabIndex = 5;
            lblQaliq.Text = "Qalıq";
            // 
            // lblMebleg
            // 
            lblMebleg.AutoSize = true;
            lblMebleg.Location = new Point(25, 306);
            lblMebleg.Name = "lblMebleg";
            lblMebleg.Size = new Size(60, 20);
            lblMebleg.TabIndex = 4;
            lblMebleg.Text = "Məbləğ";
            lblMebleg.Click += label5_Click;
            // 
            // txtMuddet
            // 
            txtMuddet.Location = new Point(75, 248);
            txtMuddet.Name = "txtMuddet";
            txtMuddet.Size = new Size(105, 27);
            txtMuddet.TabIndex = 3;
            // 
            // lblMuddet
            // 
            lblMuddet.AutoSize = true;
            lblMuddet.Location = new Point(11, 251);
            lblMuddet.Name = "lblMuddet";
            lblMuddet.Size = new Size(64, 20);
            lblMuddet.TabIndex = 2;
            lblMuddet.Text = "Müddət:";
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 69);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(155, 122);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // lblCafe
            // 
            lblCafe.AutoSize = true;
            lblCafe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCafe.Location = new Point(49, 27);
            lblCafe.Name = "lblCafe";
            lblCafe.Size = new Size(64, 31);
            lblCafe.TabIndex = 0;
            lblCafe.Text = "Cafe";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(txtHesab);
            panel2.Controls.Add(lblHesab);
            panel2.Controls.Add(btnYekunHesab);
            panel2.Controls.Add(btnYenile);
            panel2.Controls.Add(btnSil);
            panel2.Controls.Add(lstSebet);
            panel2.Controls.Add(lblSebet);
            panel2.Location = new Point(585, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 578);
            panel2.TabIndex = 1;
            // 
            // txtHesab
            // 
            txtHesab.Location = new Point(74, 529);
            txtHesab.Name = "txtHesab";
            txtHesab.Size = new Size(107, 27);
            txtHesab.TabIndex = 14;
            // 
            // lblHesab
            // 
            lblHesab.AutoSize = true;
            lblHesab.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHesab.Location = new Point(4, 530);
            lblHesab.Name = "lblHesab";
            lblHesab.Size = new Size(64, 23);
            lblHesab.TabIndex = 13;
            lblHesab.Text = "Hesab:";
            // 
            // btnYekunHesab
            // 
            btnYekunHesab.Location = new Point(19, 471);
            btnYekunHesab.Name = "btnYekunHesab";
            btnYekunHesab.Size = new Size(162, 35);
            btnYekunHesab.TabIndex = 12;
            btnYekunHesab.Text = "Yekun hesab";
            btnYekunHesab.UseVisualStyleBackColor = true;
            btnYekunHesab.Click += btnYekunHesab_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(19, 421);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(162, 35);
            btnYenile.TabIndex = 11;
            btnYenile.Text = "Yenilə";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(19, 370);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(162, 35);
            btnSil.TabIndex = 10;
            btnSil.Text = "Səbətdən Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lstSebet
            // 
            lstSebet.FormattingEnabled = true;
            lstSebet.Location = new Point(18, 95);
            lstSebet.Name = "lstSebet";
            lstSebet.Size = new Size(163, 244);
            lstSebet.TabIndex = 3;
            // 
            // lblSebet
            // 
            lblSebet.AutoSize = true;
            lblSebet.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSebet.Location = new Point(61, 38);
            lblSebet.Name = "lblSebet";
            lblSebet.Size = new Size(73, 31);
            lblSebet.TabIndex = 2;
            lblSebet.Text = "Səbət";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(343, 23);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(90, 38);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Menu";
            // 
            // pbTort
            // 
            pbTort.Image = (Image)resources.GetObject("pbTort.Image");
            pbTort.Location = new Point(205, 107);
            pbTort.Name = "pbTort";
            pbTort.Size = new Size(116, 96);
            pbTort.SizeMode = PictureBoxSizeMode.Zoom;
            pbTort.TabIndex = 2;
            pbTort.TabStop = false;
            // 
            // pbKola
            // 
            pbKola.Image = (Image)resources.GetObject("pbKola.Image");
            pbKola.Location = new Point(327, 107);
            pbKola.Name = "pbKola";
            pbKola.Size = new Size(130, 96);
            pbKola.SizeMode = PictureBoxSizeMode.Zoom;
            pbKola.TabIndex = 3;
            pbKola.TabStop = false;
            // 
            // pbLimonad
            // 
            pbLimonad.Image = (Image)resources.GetObject("pbLimonad.Image");
            pbLimonad.Location = new Point(463, 107);
            pbLimonad.Name = "pbLimonad";
            pbLimonad.Size = new Size(116, 96);
            pbLimonad.SizeMode = PictureBoxSizeMode.Zoom;
            pbLimonad.TabIndex = 4;
            pbLimonad.TabStop = false;
            // 
            // pbBurger
            // 
            pbBurger.Image = (Image)resources.GetObject("pbBurger.Image");
            pbBurger.Location = new Point(205, 288);
            pbBurger.Name = "pbBurger";
            pbBurger.Size = new Size(116, 96);
            pbBurger.SizeMode = PictureBoxSizeMode.Zoom;
            pbBurger.TabIndex = 5;
            pbBurger.TabStop = false;
            // 
            // pbSendvic
            // 
            pbSendvic.Image = (Image)resources.GetObject("pbSendvic.Image");
            pbSendvic.Location = new Point(327, 288);
            pbSendvic.Name = "pbSendvic";
            pbSendvic.Size = new Size(130, 96);
            pbSendvic.SizeMode = PictureBoxSizeMode.Zoom;
            pbSendvic.TabIndex = 6;
            pbSendvic.TabStop = false;
            // 
            // pbPizza
            // 
            pbPizza.Image = (Image)resources.GetObject("pbPizza.Image");
            pbPizza.Location = new Point(463, 288);
            pbPizza.Name = "pbPizza";
            pbPizza.Size = new Size(116, 96);
            pbPizza.SizeMode = PictureBoxSizeMode.Zoom;
            pbPizza.TabIndex = 7;
            pbPizza.TabStop = false;
            // 
            // pbRulet
            // 
            pbRulet.Image = (Image)resources.GetObject("pbRulet.Image");
            pbRulet.Location = new Point(205, 443);
            pbRulet.Name = "pbRulet";
            pbRulet.Size = new Size(116, 96);
            pbRulet.SizeMode = PictureBoxSizeMode.Zoom;
            pbRulet.TabIndex = 8;
            pbRulet.TabStop = false;
            // 
            // pbHotdog
            // 
            pbHotdog.Image = (Image)resources.GetObject("pbHotdog.Image");
            pbHotdog.Location = new Point(327, 443);
            pbHotdog.Name = "pbHotdog";
            pbHotdog.Size = new Size(130, 96);
            pbHotdog.SizeMode = PictureBoxSizeMode.Zoom;
            pbHotdog.TabIndex = 9;
            pbHotdog.TabStop = false;
            // 
            // pbPecenye
            // 
            pbPecenye.Image = (Image)resources.GetObject("pbPecenye.Image");
            pbPecenye.Location = new Point(463, 443);
            pbPecenye.Name = "pbPecenye";
            pbPecenye.Size = new Size(116, 96);
            pbPecenye.SizeMode = PictureBoxSizeMode.Zoom;
            pbPecenye.TabIndex = 10;
            pbPecenye.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 573);
            Controls.Add(pbPecenye);
            Controls.Add(pbHotdog);
            Controls.Add(pbRulet);
            Controls.Add(pbPizza);
            Controls.Add(pbSendvic);
            Controls.Add(pbBurger);
            Controls.Add(pbLimonad);
            Controls.Add(pbKola);
            Controls.Add(pbTort);
            Controls.Add(lblMenu);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Cafe System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTort).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKola).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLimonad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSendvic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPizza).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRulet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHotdog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPecenye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblCafe;
        private Panel panel2;
        private Label lblSebet;
        private Label lblMenu;
        private Label lblMuddet;
        private PictureBox pbLogo;
        private Label lblQaliq;
        private Label lblMebleg;
        private TextBox txtMuddet;
        private Button btnHesabla;
        private TextBox txtQaliq;
        private MaskedTextBox mtbMebleg;
        private Button btnTemizle;
        private TextBox txtHesab;
        private Label lblHesab;
        private Button btnYekunHesab;
        private Button btnYenile;
        private Button btnSil;
        private ListBox lstSebet;
        private PictureBox pbTort;
        private PictureBox pbKola;
        private PictureBox pbLimonad;
        private PictureBox pbBurger;
        private PictureBox pbSendvic;
        private PictureBox pbPizza;
        private PictureBox pbRulet;
        private PictureBox pbHotdog;
        private PictureBox pbPecenye;
    }
}

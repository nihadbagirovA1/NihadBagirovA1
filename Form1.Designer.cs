namespace sinifisi
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSDF1 = new MaskedTextBox();
            txtSDF2 = new MaskedTextBox();
            txtFF = new MaskedTextBox();
            txtSeminar = new MaskedTextBox();
            txtFinal = new MaskedTextBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnHesabla = new Button();
            btnSifirla = new Button();
            txtTelebeNomresi = new MaskedTextBox();
            txtAdSoyad = new TextBox();
            dgvNeticeler = new DataGridView();
            fullname = new DataGridViewTextBoxColumn();
            NUMBER = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            Kataqori = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNeticeler).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 51);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 1;
            label1.Text = "Imtahan sistemi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 151);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "SDF1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 218);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "SDF2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 292);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 3;
            label4.Text = "FF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 365);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "SEMINAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 441);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "FINAL";
            // 
            // txtSDF1
            // 
            txtSDF1.Location = new Point(95, 148);
            txtSDF1.Mask = "000";
            txtSDF1.Name = "txtSDF1";
            txtSDF1.Size = new Size(71, 23);
            txtSDF1.TabIndex = 6;
            txtSDF1.ValidatingType = typeof(int);
            // 
            // txtSDF2
            // 
            txtSDF2.Location = new Point(95, 215);
            txtSDF2.Mask = "000";
            txtSDF2.Name = "txtSDF2";
            txtSDF2.Size = new Size(71, 23);
            txtSDF2.TabIndex = 7;
            txtSDF2.ValidatingType = typeof(int);
            // 
            // txtFF
            // 
            txtFF.Location = new Point(95, 289);
            txtFF.Mask = "000";
            txtFF.Name = "txtFF";
            txtFF.Size = new Size(71, 23);
            txtFF.TabIndex = 8;
            txtFF.ValidatingType = typeof(int);
            // 
            // txtSeminar
            // 
            txtSeminar.Location = new Point(95, 362);
            txtSeminar.Mask = "000";
            txtSeminar.Name = "txtSeminar";
            txtSeminar.Size = new Size(71, 23);
            txtSeminar.TabIndex = 9;
            txtSeminar.ValidatingType = typeof(int);
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(95, 438);
            txtFinal.Mask = "000";
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(71, 23);
            txtFinal.TabIndex = 10;
            txtFinal.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnHesabla);
            groupBox1.Controls.Add(btnSifirla);
            groupBox1.Controls.Add(txtTelebeNomresi);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Location = new Point(226, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 308);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(27, 126);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 5;
            label7.Text = "Telebe nomresi";
            // 
            // btnHesabla
            // 
            btnHesabla.ForeColor = SystemColors.ActiveCaptionText;
            btnHesabla.Location = new Point(34, 214);
            btnHesabla.Name = "btnHesabla";
            btnHesabla.Size = new Size(139, 32);
            btnHesabla.TabIndex = 4;
            btnHesabla.Text = "Hesabla ";
            btnHesabla.UseVisualStyleBackColor = true;
            btnHesabla.Click += btnHesabla_Click;
            // 
            // btnSifirla
            // 
            btnSifirla.Location = new Point(34, 259);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(139, 32);
            btnSifirla.TabIndex = 3;
            btnSifirla.Text = "Xanalari sifirla";
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // txtTelebeNomresi
            // 
            txtTelebeNomresi.Location = new Point(27, 144);
            txtTelebeNomresi.Mask = "000000000";
            txtTelebeNomresi.Name = "txtTelebeNomresi";
            txtTelebeNomresi.Size = new Size(146, 23);
            txtTelebeNomresi.TabIndex = 1;
            txtTelebeNomresi.ValidatingType = typeof(int);
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(27, 62);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(146, 23);
            txtAdSoyad.TabIndex = 0;
            txtAdSoyad.Text = "Ad ve soyad";
            // 
            // dgvNeticeler
            // 
            dgvNeticeler.BackgroundColor = SystemColors.ActiveCaption;
            dgvNeticeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNeticeler.Columns.AddRange(new DataGridViewColumn[] { fullname, NUMBER, Result, Kataqori });
            dgvNeticeler.Location = new Point(447, 157);
            dgvNeticeler.Name = "dgvNeticeler";
            dgvNeticeler.Size = new Size(444, 299);
            dgvNeticeler.TabIndex = 12;
            // 
            // fullname
            // 
            fullname.HeaderText = "Ad ve soyad";
            fullname.Name = "fullname";
            // 
            // NUMBER
            // 
            NUMBER.HeaderText = "Telebe nomresi";
            NUMBER.Name = "NUMBER";
            // 
            // Result
            // 
            Result.HeaderText = "Netice";
            Result.Name = "Result";
            // 
            // Kataqori
            // 
            Kataqori.HeaderText = "Kateqoriya";
            Kataqori.Name = "Kataqori";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(912, 552);
            Controls.Add(dgvNeticeler);
            Controls.Add(groupBox1);
            Controls.Add(txtFinal);
            Controls.Add(txtSeminar);
            Controls.Add(txtFF);
            Controls.Add(txtSDF2);
            Controls.Add(txtSDF1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNeticeler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox txtSDF1;
        private MaskedTextBox txtSDF2;
        private MaskedTextBox txtFF;
        private MaskedTextBox txtSeminar;
        private MaskedTextBox txtFinal;
        private GroupBox groupBox1;
        private MaskedTextBox txtTelebeNomresi;
        private TextBox txtAdSoyad;
        private Label label7;
        private Button btnHesabla;
        private Button btnSifirla;
        private DataGridView dgvNeticeler;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn NUMBER;
        private DataGridViewTextBoxColumn Result;
        private DataGridViewTextBoxColumn Kataqori;
    }
}

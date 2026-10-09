namespace sinifisi
{
    public partial class Form1 : Form
    {
        private double sdf1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesabla_Click(object sender, EventArgs e)
        {
            // Xanadakı mətndən '_' və boşluqları təmizləyən funksiya
            string CleanText(string text) => text.Replace("_", "").Trim();

            // Mətnləri təmizləyirik
            string sSDF1 = CleanText(txtSDF1.Text);
            string sSDF2 = CleanText(txtSDF2.Text);
            string sFF = CleanText(txtFF.Text);
            string sSeminar = CleanText(txtSeminar.Text);
            string sFinal = CleanText(txtFinal.Text);

            // Yoxlamalar
            if (!double.TryParse(sSDF1, out double sdf1) || sdf1 < 0 || sdf1 > 10)
            {
                MessageBox.Show("SDF1 balı 0 ilə 10 arasında olmalıdır!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(sSDF2, out double sdf2) || sdf2 < 0 || sdf2 > 10)
            {
                MessageBox.Show("SDF2 balı 0 ilə 10 arasında olmalıdır!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(sFF, out double ff) || ff < 0 || ff > 10)
            {
                MessageBox.Show("FF balı 0 ilə 10 arasında olmalıdır!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(sSeminar, out double seminar) || seminar < 0 || seminar > 20)
            {
                MessageBox.Show("Seminar balı 0 ilə 20 arasında olmalıdır!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(sFinal, out double final) || final < 0 || final > 50)
            {
                MessageBox.Show("Final balı 0 ilə 50 arasında olmalıdır!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || string.IsNullOrWhiteSpace(txtTelebeNomresi.Text))
            {
                MessageBox.Show("Zəhmət olmasa tələbənin ad, soyad və nömrəsini daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ümumi bal
            double umumiBal = sdf1 + sdf2 + ff + seminar + final;

            // Kateqoriya
            string kateqoriya = "";
            if (umumiBal >= 91) kateqoriya = "A";
            else if (umumiBal >= 81) kateqoriya = "B";
            else if (umumiBal >= 71) kateqoriya = "C";
            else if (umumiBal >= 61) kateqoriya = "D";
            else if (umumiBal >= 51) kateqoriya = "E";
            else kateqoriya = "F";

            // Cədvələ əlavə etmək
            dgvNeticeler.Rows.Add(txtAdSoyad.Text, txtTelebeNomresi.Text, umumiBal, kateqoriya);
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            txtSDF1.Clear();
            txtSDF2.Clear();
            txtFF.Clear();
            txtSeminar.Clear();
            txtFinal.Clear();
            txtAdSoyad.Clear();
            txtTelebeNomresi.Clear();
        }
    }
}

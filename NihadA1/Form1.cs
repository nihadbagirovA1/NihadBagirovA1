namespace NihadA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userFilePath = "users.txt";
            string ad = txtRegAd.Text;
            string soyad = txtRegSoyad.Text;
            string email = txtRegEmail.Text;
            string sifre = txtRegSifre.Text;

            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Zəhmət olmasa bütün sahələri doldurun.");
                return;
            }

            string line = ad + "," + soyad + "," + email + "," + sifre;
            File.AppendAllText(userFilePath, line + Environment.NewLine);

            MessageBox.Show("Qeydiyyat uğurla tamamlandı!","Uğurlu",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtRegAd.Clear();
            txtRegSoyad.Clear();
            txtRegEmail.Clear();
            txtRegSifre.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userFilePath = "users.txt";
            string email = txtLoginUser.Text;
            string sifre = txtLoginPass.Text;

            if (!File.Exists(userFilePath))
            {
                MessageBox.Show("Hesab tapılmadı. Zəhmət olmasa əvvəlcə qeydiyyatdan keçin.","Xəta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(userFilePath);
            bool found = false;

            foreach (string l in lines)
            {
                string[] parts = l.Split(',');
                if (parts.Length == 4 && parts[2] == email && parts[3] == sifre)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                MessageBox.Show("Giriş uğurludur! Xoş gəldiniz.","Uğurlu",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hesab tapılmadı. İstifadəçi adı və ya şifrə yalnışdır.","Xəta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

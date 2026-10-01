namespace Ev_isi4
{
    public partial class Form1 : Form
    {
        Dictionary<string, decimal> qiymetler = new Dictionary<string, decimal>
{
    { "Tort", 4.50m },
    { "Kola", 1.50m },
    { "Limonad", 2.00m },
    { "Burger", 5.50m },
    { "Sendviç", 3.50m },
    { "Pizza", 4.00m },
    { "Rulet", 2.50m },
    { "Hot-dog", 3.00m },
    { "Peçenye", 1.00m }
};

        public Form1()
        {
            InitializeComponent();

            pbTort.Tag = "Tort";
            pbKola.Tag = "Kola";
            pbLimonad.Tag = "Limonad";
            pbBurger.Tag = "Burger";
            pbSendvic.Tag = "Sendviç";
            pbPizza.Tag = "Pizza";
            pbRulet.Tag = "Rulet";
            pbHotdog.Tag = "Hot-dog";
            pbPecenye.Tag = "Peçenye";

            PictureBox[] sekiller = { pbTort, pbKola, pbLimonad, pbBurger, pbSendvic,
                              pbPizza, pbRulet, pbHotdog, pbPecenye };
            foreach (PictureBox pb in sekiller)
                pb.Click += Yemek_Click;
        }

        private void Yemek_Click(object sender, EventArgs e)
        {
            string ad = ((PictureBox)sender).Tag.ToString();
            lstSebet.Items.Add(new Yemek(ad, qiymetler[ad]));
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstSebet.SelectedItem == null)
            {
                MessageBox.Show("Silmək üçün siyahıdan yemək seçin!");
                return;
            }

            Yemek y = (Yemek)lstSebet.SelectedItem;
            lstSebet.Items.Remove(y);
            MessageBox.Show(y.Ad + " səbətdən silindi");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Xanalar sıfırlansınmı?", "Təsdiq",
                                         MessageBoxButtons.YesNo);
            if (cavab == DialogResult.Yes)
            {
                lstSebet.Items.Clear();
                mtbMebleg.Clear();
                txtQaliq.Clear();
                txtHesab.Clear();
                txtMuddet.Clear();
            }
        }

        private void btnYekunHesab_Click(object sender, EventArgs e)
        {
            if (lstSebet.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
                return;
            }

            decimal cem = 0;
            foreach (Yemek y in lstSebet.Items)
                cem += y.Qiymet;

            txtHesab.Text = cem.ToString("0.00");
        }

        private void btnHesabla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHesab.Text))
            {
                MessageBox.Show("Əvvəlcə Yekun hesab düyməsinə basın!");
                return;
            }

            decimal hesab = decimal.Parse(txtHesab.Text);

            decimal mebleg;
            if (!decimal.TryParse(mtbMebleg.Text.Trim(), out mebleg))
            {
                MessageBox.Show("Məbləği daxil edin!");
                return;
            }

            if (mebleg < hesab)
            {
                MessageBox.Show("Daxil edilən məbləğ hesabdan azdır");
                return;
            }

            txtQaliq.Text = (mebleg - hesab).ToString("0.00");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            mtbMebleg.Clear();
            txtQaliq.Clear();
        }
    }
    public class Yemek
    {
        public string Ad;
        public decimal Qiymet;

        public Yemek(string ad, decimal qiymet)
        {
            Ad = ad;
            Qiymet = qiymet;
        }

        public override string ToString()
        {
            return Ad + " - " + Qiymet.ToString("0.00") + " AZN";
        }
    }
}

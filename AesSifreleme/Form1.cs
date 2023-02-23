namespace AesSifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        aesSifreleveCoz AES_Metodum=new aesSifreleveCoz();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sifrele_Click(object sender, EventArgs e)
        {
            rtbSifreli.Text = AES_Metodum.AESsifrele(txtGizliMetin.Text);

        }

        private void SifreCoz_Click(object sender, EventArgs e)
        {
            if(rtbSifreli.Text==string.Empty)
            {
                MessageBox.Show("Çözülecek metin yok");
            }
            else
                rtbSifresiz.Text= AES_Metodum.AESsifre_Coz(rtbSifreli.Text);
        }
    }
}
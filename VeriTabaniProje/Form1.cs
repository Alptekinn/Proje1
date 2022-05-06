namespace VeriTabaniProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpStandartRezervasyon.Enabled = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri m=new Musteri();
            RezervasyonFiyat r = new RezervasyonFiyat();

            m.Ad=txtAd.Text;
            m.Soyad=txtSoyad.Text;
            m.TC = txtRezervasyonTc.Text;
            m.Mail=txtEmail.Text; 
            m.TelefonNo=txtTelefonNo.Text;


            r.Fiyat(dtpRezervasyonTarihi, dtpCikisTarihi, grpStandartRezervasyon);
            lblFiyat.Text = r.Mesaj;



            m.musteriBilgileriniVeritabaninaYukle();
            m.musteriIDCek();
            m.IDyiRezervasyonTablosunaEkle(Convert.ToInt32(lblFiyat.Text),dtpRezervasyonTarihi,dtpCikisTarihi);
            MessageBox.Show("Kayýt baþarýlý!!!");


        }
    }
}
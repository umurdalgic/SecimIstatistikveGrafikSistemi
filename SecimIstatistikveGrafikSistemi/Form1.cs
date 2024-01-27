using SecimIstatistikveGrafikSistemi.Models;

namespace SecimIstatistikveGrafikSistemi
{
    public partial class Form1 : Form
    {
        private SecimDbContext db = new SecimDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOyGirisi_Click(object sender, EventArgs e)
        {
            Ilce ilce = new Ilce()
            {
                IlceAd = txtIlceAdi.Text,
                Aparti = short.Parse(txtAParti.Text),
                Bparti = short.Parse(txtBParti.Text),
                Cparti = short.Parse(txtCParti.Text),
                Dparti = short.Parse(txtDParti.Text),
                Eparti = short.Parse(txtEParti.Text)
            };
            db.Ilces.Add(ilce);
            db.SaveChanges();
            MessageBox.Show("Oy giriþi baþarýlý.");
            foreach(Control textBox in this.Controls)
            {
                if(textBox is TextBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            frmGrafikler frm=new frmGrafikler();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
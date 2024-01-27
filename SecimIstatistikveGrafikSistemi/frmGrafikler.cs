using SecimIstatistikveGrafikSistemi.Models;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecimIstatistikveGrafikSistemi
{
    public partial class frmGrafikler : Form
    {
        private SecimDbContext db = new SecimDbContext();

        public frmGrafikler()
        {
            InitializeComponent();
        }
        private short? APartiToplami()
        {
            var aPartiToplamOy = db.Ilces.ToList();
            short? toplamOy = 0;
            for (int i = 0; i < aPartiToplamOy.Count; i++)
            {
                toplamOy += aPartiToplamOy[i].Aparti;
            }

            return toplamOy;
        }
        private short? BPartiToplami()
        {
            var partiToplamOy = db.Ilces.ToList();
            short? toplamOy = 0;
            for (int i = 0; i < partiToplamOy.Count; i++)
            {
                toplamOy += partiToplamOy[i].Bparti;
            }

            return toplamOy;
        }
        private short? CPartiToplami()
        {
            var partiToplamOy = db.Ilces.ToList();
            short? toplamOy = 0;
            for (int i = 0; i < partiToplamOy.Count; i++)
            {
                toplamOy += partiToplamOy[i].Cparti;
            }

            return toplamOy;
        }
        private short? DPartiToplami()
        {
            var partiToplamOy = db.Ilces.ToList();
            short? toplamOy = 0;
            for (int i = 0; i < partiToplamOy.Count; i++)
            {
                toplamOy += partiToplamOy[i].Dparti;
            }

            return toplamOy;
        }
        private short? EPartiToplami()
        {
            var partiToplamOy = db.Ilces.ToList();
            short? toplamOy = 0;
            for (int i = 0; i < partiToplamOy.Count; i++)
            {
                toplamOy += partiToplamOy[i].Eparti;
            }

            return toplamOy;
        }

        private void frmGrafikler_Load(object sender, EventArgs e)
        {
            #region chart doldurma
            ChartSeries chartSeries = new ChartSeries("Partiler", ChartSeriesType.Column);
            chartSeries.Points.Add("A Parti", Convert.ToDouble(APartiToplami()));
            chartSeries.Points.Add("B Parti", Convert.ToDouble(BPartiToplami()));
            chartSeries.Points.Add("C Parti", Convert.ToDouble(CPartiToplami()));
            chartSeries.Points.Add("D Parti", Convert.ToDouble(DPartiToplami()));
            chartSeries.Points.Add("E Parti", Convert.ToDouble(EPartiToplami()));
            this.chartControl1.Series.Add(chartSeries);
            #endregion
            #region combobox doldurma
            var ilceIsimleri = db.Ilces.ToList();
            for (int i = 0; i < ilceIsimleri.Count; i++)
            {
                comboBox1.Items.Add(ilceIsimleri[i].IlceAd);
            }
            #endregion
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string secilenIlce = comboBox1.SelectedItem.ToString();
            var gosterilecekIlce = db.Ilces.FirstOrDefault(x => x.IlceAd == secilenIlce);
            int aParti = Convert.ToInt32(gosterilecekIlce.Aparti);
            int bParti = Convert.ToInt32(gosterilecekIlce.Bparti);
            int cParti = Convert.ToInt32(gosterilecekIlce.Cparti);
            int dParti = Convert.ToInt32(gosterilecekIlce.Dparti);
            int eParti = Convert.ToInt32(gosterilecekIlce.Eparti);
            int toplamOy = aParti + bParti + cParti + dParti + eParti;
            foreach (Control control in this.Controls)
            {
                if (control is ProgressBar)
                {
                    ((ProgressBar)control).Maximum = toplamOy;
                }
            }

            label7.Text = aParti.ToString();
            label8.Text = bParti.ToString();
            label9.Text = cParti.ToString();
            label10.Text = dParti.ToString();
            label11.Text = eParti.ToString();
            progressBar1.Value = aParti;
            progressBar2.Value = bParti;
            progressBar3.Value = cParti;
            progressBar4.Value = dParti;
            progressBar5.Value = eParti;
        }
    }

}

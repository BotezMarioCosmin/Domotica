using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Domotica
{
    public partial class Form1 : Form
    {
        private Telecomando t;
        private Tv tv;

        bool tvOn = false;
        public Form1()
        {
            InitializeComponent();
            t = new Telecomando("samsung", "tel-08", true, false, true);
            tv = new Tv("samsung", "qled", 50, 55, 1080, 1920, "ips", true, true, 4);
            pnlTvOff.Show();

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxOnOff.Width - 3, pictureBoxOnOff.Height - 3);
            Region rg = new Region(gp);
            pictureBoxOnOff.Region = rg;

            pnlTv.Controls.Add(pictureBoxVol);
            pictureBoxVol.BackColor = Color.Transparent;
            pictureBoxVol.Hide();

            //textBoxProduttoreModello.Text = tv.getProduttore() + " " + tv.getModello();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int volume;

            lblCanale.Text = Convert.ToString(t.getCanaleTv());
            volume = t.getVolumeTv();

            volume = checkVolume(volume);
            t.setVolumeTv(volume);

            lblVolume.Text = Convert.ToString(volume);
        }

        private void btnClearCanale_Click(object sender, EventArgs e)
        {
            textBoxCanale.Text = null;
        }

        private void btnGetCanale_Click(object sender, EventArgs e)
        {
            textBoxCanale.Text = Convert.ToString(t.getCanaleTv());
        }

        private void btnSetCanale_Click(object sender, EventArgs e)
        {
            t.setCanaleTv(Convert.ToInt32(textBoxCanale.Text));
            textBoxCanale.Text = null;
        }

        private void btnGetVolume_Click(object sender, EventArgs e)
        {
            textBoxVolume.Text = Convert.ToString(t.getVolumeTv());
        }

        private void btnClearVolume_Click(object sender, EventArgs e)
        {
            textBoxVolume.Text = null;
        }

        private void btnSetVolume_Click(object sender, EventArgs e)
        {
            t.setVolumeTv(Convert.ToInt32(textBoxVolume.Text));
            textBoxVolume.Text = null;
        }

        public static int checkVolume(int v) // controlla che il volume sia tra 0 e 100
        {
            if (v > 100 || v < 0)
            {
                return 0;
            }
            else
                return v;
        }

        private void pictureBoxOnOff_Click(object sender, EventArgs e)
        {
            if (tvOn == false)
            {
                t.accendiTv();
                tvOn = true;
                pnlTvOff.Hide();
            }
            else if (tvOn == true)
            {
                t.spegniTv();
                tvOn = false;
                pnlTvOff.Show();
            }
        }

        private void btnVolumeSu_Click(object sender, EventArgs e) // aggiunge 1 al volume
        {
            int v = t.getVolumeTv();
            t.volumeSu(v);
        }

        private void btnVolumeGiu_Click(object sender, EventArgs e) // diminuisce 1 al volume
        {
            int v = t.getVolumeTv();
            t.volumeGiu(v);
        }

        private void btnCanaleSu_Click(object sender, EventArgs e) // aggiunge 1 al canale
        {
            int c = t.getCanaleTv();
            t.canaleSu(c);
        }

        private void btnCanaleGiu_Click(object sender, EventArgs e) // diminuisce di 1 il canale
        {
            int c = t.getCanaleTv();
            t.canaleGiu(c);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            t.setCanaleTv(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            t.setCanaleTv(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            t.setCanaleTv(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            t.setCanaleTv(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            t.setCanaleTv(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            t.setCanaleTv(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            t.setCanaleTv(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            t.setCanaleTv(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            t.setCanaleTv(9);
        }

        private void btnMuto_Click(object sender, EventArgs e)
        {
            bool muto = t.volumeMuto();
            if (muto == true)
            {
                lblVolume.Hide();
                pictureBoxVol.Show();
            }
            else
            {
                lblVolume.Show();
                pictureBoxVol.Hide();
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            t.setCanaleTv(0);
        }
    }
}

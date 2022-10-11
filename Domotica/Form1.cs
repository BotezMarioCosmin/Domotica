using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Domotica
{
    public partial class Form1 : Form
    {
        private Telecomando t;

        bool tvOn = false;
        public Form1()
        {
            InitializeComponent();
            t = new Telecomando("samsung", "a1", true, false, false);

            pnlTvOff.Show();

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBoxOnOff.Width - 3, pictureBoxOnOff.Height - 3);
            Region rg = new Region(gp);
            pictureBoxOnOff.Region = rg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int volume;

            lblCanale.Text = Convert.ToString(t.getCanale());
            volume = t.getVolume();

            volume = checkVolume(volume);
            t.setVolume(volume);

            lblVolume.Text = Convert.ToString(volume);
        }

        private void btnClearCanale_Click(object sender, EventArgs e)
        {
            textBoxCanale.Text = null;
        }

        private void btnGetCanale_Click(object sender, EventArgs e)
        {
            textBoxCanale.Text = Convert.ToString(t.getCanale());
        }

        private void btnSetCanale_Click(object sender, EventArgs e)
        {
            t.setCanale(Convert.ToInt32(textBoxCanale.Text));
        }

        private void btnGetVolume_Click(object sender, EventArgs e)
        {
            textBoxVolume.Text = Convert.ToString(t.getVolume());
        }

        private void btnClearVolume_Click(object sender, EventArgs e)
        {
            textBoxVolume.Text = null;
        }

        private void btnSetVolume_Click(object sender, EventArgs e)
        {
            t.setVolume(Convert.ToInt32(textBoxVolume.Text));
        }

        public static int checkVolume(int v)
        {
            if (v >= 100)
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
                tvOn = true;
                pnlTvOff.Hide();
            }
            else if (tvOn == true)
            {
                tvOn = false;
                pnlTvOff.Show();
            }
        }

        private void btnVolumeSu_Click(object sender, EventArgs e)
        {
            int v = t.getVolume();

            t.setVolume(v+1);
        }

        private void btnVolumeGiu_Click(object sender, EventArgs e)
        {
            int v = t.getVolume();

            t.setVolume(v - 1);
        }
    }
}

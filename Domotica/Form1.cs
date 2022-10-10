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
        public Form1()
        {
            InitializeComponent();
            t = new Telecomando("samsung", "a1", true, false, false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCanale.Text = Convert.ToString(t.getCanale());
            lblVolume.Text = Convert.ToString(t.getVolume());
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
    }
}

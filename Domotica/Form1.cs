using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
             

        }
    }
}

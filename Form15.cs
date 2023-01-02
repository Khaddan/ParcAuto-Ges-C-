using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ges_PARCAUTO
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 599)
            {
                timer1.Stop();
                Form1 fm1 = new Form1();
                fm1.Show();
                this.Hide();
            }
        }
    }
}

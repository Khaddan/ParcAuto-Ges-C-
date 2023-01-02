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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panel1.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panel1.Visible == true)
                panel1.Visible = false;

        }
        private void shoxSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            shoxSubMenu(panel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            //code;;;
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Form12());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Form9());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Form10());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new Form13());
        }
    }
}

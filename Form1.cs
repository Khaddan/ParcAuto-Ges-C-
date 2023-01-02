using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ges_PARCAUTO
{
    public partial class Form1 : Form
    {
        public SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlDataReader odr, odr1;
        public SqlTransaction otr;
        public Form1()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*textBox1.BackColor = Color.White;
             panel4.BackColor = Color.White;
             panel5.BackColor = SystemColors.Control;
             textBox2.BackColor = SystemColors.Control;*/
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*textBox2.BackColor = Color.White;
             panel5.BackColor = Color.White;
             textBox1.BackColor = SystemColors.Control;
             panel4.BackColor = SystemColors.Control;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ADMIN" && textBox2.Text == "1234")
            {
                new Form3().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("The user name or password you entered is incorrect , try again!!");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }

        }    





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = true;
            else
                textBox2.UseSystemPasswordChar = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form12().Show();
            this.Hide();
        }



        /* private void button1_KeyPress(object sender, KeyPressEventArgs e)
         {


         }*/

        /*private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "Nom d'utilisateur" || textBox1.Text == "ADMIN")
                {
                    MessageBox.Show("Saisie Le Nom D'utilisateur", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox1.Text = textBox1.Text;
                    textBox2.Focus();
                }
            }
        }*/

    }
}

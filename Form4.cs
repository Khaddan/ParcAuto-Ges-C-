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
    public partial class Form4 : Form
    {
        public SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlDataReader odr, odr1;
        public SqlTransaction otr;
        public Form4()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "select idConducteur from Conducteurs";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    comboBox1.Items.Add(odr["idConducteur"]);
                }
                odr.Close();
                ocon.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "  update  Conducteurs  set nom ='" + textBox1.Text + "',prénom ='" + textBox2.Text + "',N_Matricule ='" + textBox3.Text + "',adresse ='" + textBox4.Text + "',type_permis ='" + textBox5.Text + "',dateExipationPermis ='" + dateTimePicker1.Text + "',dateNaissance ='" + dateTimePicker2.Text + "'where idConducteur ='" + comboBox1.Text + "'";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from Conducteurs";
                odr1 = ocom1.ExecuteReader();
                DataTable dtb = new DataTable();
                dtb.Load(odr1);
                dataGridView1.DataSource = dtb;
                odr1.Close();

                ocon.Close();
                MessageBox.Show("la modification est fait");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }

            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = " delete from  Conducteurs  where  idConducteur = '" + comboBox1.Text + "'";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from Conducteurs";
                odr1 = ocom1.ExecuteReader();
                DataTable dtb = new DataTable();
                dtb.Load(odr1);
                dataGridView1.DataSource = dtb;
                odr1.Close();

                ocon.Close();
                MessageBox.Show("vous avez suprimer cette case");

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            try
            {

                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "Select nom,prénom,N_Matricule,adresse,type_permis,dateExipationPermis,dateNaissance from Conducteurs where idConducteur ='" + comboBox1.SelectedItem + "' ";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    textBox1.Text = odr[0].ToString();
                    textBox2.Text = odr[1].ToString();
                    textBox3.Text = odr[2].ToString();
                    textBox4.Text = odr[3].ToString();
                    textBox5.Text = odr[4].ToString();
                    dateTimePicker1.Text = odr[5].ToString();
                    dateTimePicker2.Text = odr[6].ToString();
                }

                odr.Close();
                ocon.Close();
                //MessageBox.Show("successfuly");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}

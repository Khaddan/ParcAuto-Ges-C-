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
    public partial class Form8 : Form
    {
        public SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlCommand ocom2 = new SqlCommand();
        public SqlCommand ocom3 = new SqlCommand();
        public SqlCommand ocom4 = new SqlCommand();
        public SqlCommand ocom5 = new SqlCommand();
        public SqlDataReader odr, odr1, odr2, odr3, odr4, odr5;

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
            new Form5().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }

            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = " delete from  Véhicules  where  Matricule = '" + textBox1.Text + "'";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from Véhicules";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "  update  Véhicules  set Matricule ='" + textBox1.Text + "',typeV ='" + textBox3.Text + "',marqueV ='" + textBox4.Text + "',modelV ='" + textBox5.Text + "',carburant ='" + textBox6.Text + "'where Matricule ='" + comboBox1.Text + "'";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from Véhicules";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "Select Matricule,typeV,marqueV,modelV,carburant from  Véhicules  where  Matricule ='" + comboBox1.SelectedItem + "' ";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    textBox1.Text = odr[0].ToString();
                    textBox3.Text = odr[1].ToString();
                    textBox4.Text = odr[2].ToString();
                    textBox5.Text = odr[3].ToString();
                    textBox6.Text = odr[4].ToString();
                    
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

        public SqlTransaction otr;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "select Matricule  from Véhicules";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    comboBox1.Items.Add(odr["Matricule"]);
                }
                odr.Close();
                ocon.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}

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
    public partial class Form7 : Form
    {
        public SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlDataReader odr, odr1;
        public SqlTransaction otr;
        public Form7()
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

        private void button3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }
            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "insert into DetailVehicule (matriV,ConditionV,dateDebutAss,DateFinAss,Vingnette) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + comboBox3.Text + "')";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from DetailVehicule";
                odr1 = ocom1.ExecuteReader();
                DataTable dtb = new DataTable();
                dtb.Load(odr1);
                dataGridView1.DataSource = dtb;
                odr1.Close();

                ocon.Close();
                MessageBox.Show("Added Successfully");
                comboBox1.Text = comboBox2.Text = dateTimePicker1.Text = dateTimePicker2.Text = comboBox3.Text =  "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }
            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = " update DetailVehicule set  ConditionV ='" + comboBox2.Text +  "',dateDebutAss ='" + dateTimePicker1.Text + "',DateFinAss='" + dateTimePicker2.Text + "',Vingnette='" + comboBox3.Text + "' where matriV = '" +comboBox1.Text+"' ";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from DetailVehicule";
                odr1 = ocom1.ExecuteReader();
                DataTable dtb = new DataTable();
                dtb.Load(odr1);
                dataGridView1.DataSource = dtb;
                odr1.Close();

                ocon.Close();
                MessageBox.Show("Added Successfully");
                comboBox1.Text = comboBox2.Text = dateTimePicker1.Text = dateTimePicker2.Text = comboBox3.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            try
            {
               
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "select Matricule from Véhicules ";
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

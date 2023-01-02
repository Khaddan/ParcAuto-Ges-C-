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
    public partial class Form11 : Form
    {
        public SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlDataReader odr, odr1;
        public SqlTransaction otr;
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "Select matriV,N_Matricule,F_Carburant,F_Autoroute,F_Depla ,Deja_Repa ,F_reparation from Frais where id ='" + comboBox3.SelectedItem + "' ";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    comboBox1.Text = odr[0].ToString();
                    comboBox2.Text = odr[1].ToString();
                    textBox1.Text = odr[2].ToString();
                    textBox2.Text = odr[3].ToString();
                    textBox3.Text = odr[4].ToString();
                    comboBox4.Text = odr[5].ToString();
                    textBox4.Text = odr[6].ToString();
                    
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
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "  update  Frais  set matriV='" + comboBox1.Text + "',N_Matricule ='" + comboBox2.Text + "',F_Carburant ='" + textBox1.Text + "',F_Autoroute ='" + textBox2.Text + "',F_Depla ='" + textBox3.Text + "',Deja_Repa ='" + comboBox4.Text + "',F_reparation ='" + textBox4.Text +   "'where id ='" + comboBox3.Text + "'";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from Frais";
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

        private void Form11_Load(object sender, EventArgs e)
        {
            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "select id from Frais";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    comboBox3.Items.Add(odr["id"]);
                }
                odr.Close();
                ocon.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form9().Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
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
                ocom.CommandText = " delete from Frais where  id = '" + comboBox3.Text + "'";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from Frais";
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
    }
}

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
    public partial class Form5 : Form
    {
        public SqlConnection ocon  = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlCommand ocom2 = new SqlCommand();
        public SqlCommand ocom3 = new SqlCommand();
        public SqlCommand ocom4 = new SqlCommand();
        public SqlCommand ocom5 = new SqlCommand();
        public SqlDataReader odr, odr1, odr2 , odr3 ,odr4,odr5;
        public SqlTransaction otr;
        public DataSet ds = new DataSet();



        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }
           else
            {
                ocom = new SqlCommand("select * from Véhicules where Matricule='" + textBox1.Text + "'", ocon);
                SqlDataAdapter dat = new SqlDataAdapter(ocom);
                dat.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Matricule" + textBox1.Text + "Exist deja");
                    ds.Clear();
                }
                else
                {




                    try
                    {
                        ocon.Open();
                        ocom.Connection = ocon;
                        ocom.CommandText = "insert into Véhicules (Matricule,typeV,marqueV,modelV,carburant) values ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                        ocom.ExecuteNonQuery();


                        ocom1.Connection = ocon;
                        ocom1.CommandText = "select * from Véhicules";
                        odr1 = ocom1.ExecuteReader();
                        DataTable dtb = new DataTable();
                        dtb.Load(odr1);
                        dataGridView1.DataSource = dtb;
                        odr1.Close();

                        ocon.Close();
                        MessageBox.Show("Added Successfully");
                        textBox1.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);

                    }
                }    }
        }
        public void VIDER(Control f)
        {
            foreach (Control ct in f.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                {
                    ct.Text = "";
                }
                if (ct.Controls.Count != 0)
                {
                    VIDER(ct);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();

            /*if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }

            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "  update  Véhicules  set typeV ='" + textBox3.Text + "',marqueV ='" + textBox4.Text + "',modelV ='" + textBox5.Text + "',carburant ='" + textBox6.Text + "'where Matricule ='" + textBox1.Text + "'";
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

            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
            

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vider les champs ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public Form5()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void Form5_Load(object sender, EventArgs e)
        {
/*
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

            try
            {
                ocon.Open();
                ocom1.Connection = ocon;
                ocom1.CommandText = "select IdVehi from Véhicules ";
                odr1 = ocom1.ExecuteReader();
                while (odr1.Read())
                {
                    comboBox2.Items.Add(odr1["IdVehi"]);
                }
                odr1.Close();
                ocon.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


            try
            {
                ocon.Open();
                ocom2.Connection = ocon;
                ocom2.CommandText = "select typeV from Véhicules ";
                odr2 = ocom2.ExecuteReader();
                while (odr2.Read())
                {
                    comboBox3.Items.Add(odr2["typeV"]);
                }
                odr2.Close();
                ocon.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


            try
            {
                ocon.Open();
                ocom3.Connection = ocon;
                ocom3.CommandText = "select marqueV from Véhicules ";
                odr3 = ocom3.ExecuteReader();
                while (odr3.Read())
                {
                    comboBox4.Items.Add(odr3["marqueV"]);
                }
                odr3.Close();
                ocon.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }



            try
            {
                ocon.Open();
                ocom4.Connection = ocon;
                ocom4.CommandText = "select modelV from Véhicules ";
                odr4 = ocom4.ExecuteReader();
                while (odr4.Read())
                {
                    comboBox5.Items.Add(odr4["modelV"]);
                }
                odr4.Close();
                ocon.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }



            try
            {
                ocon.Open();
                ocom5.Connection = ocon;
                ocom5.CommandText = "select carburant from Véhicules ";
                odr5 = ocom5.ExecuteReader();
                while (odr5.Read())
                {
                    comboBox6.Items.Add(odr5["carburant"]);
                }
                odr5.Close();
                ocon.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            */

        }
    }
}

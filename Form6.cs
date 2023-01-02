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
    public partial class Form6 : Form
    {
        public SqlConnection ocon  = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlDataReader odr, odr1;
        public SqlTransaction otr;
        public DataSet ds = new DataSet();
        public Form6()
        {
            InitializeComponent();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitter ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
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
            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "select N_Matricule from Conducteurs ";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    comboBox2.Items.Add(odr["N_Matricule"]);
                }
                odr.Close();
                ocon.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
       


        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vider les champs ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || dateTimePicker1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }
            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = " update Destinations set matriC ='" + comboBox2.Text + "', depart ='" + textBox1.Text + "',dateDepart='" + dateTimePicker1.Text + "',arrive='" + textBox3.Text + "',PeriodParJour='" + textBox4.Text + "' where matriV = '" + comboBox1.Text + "' ";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from Destinations";
                odr1 = ocom1.ExecuteReader();
                DataTable dtb = new DataTable();
                dtb.Load(odr1);
                dataGridView1.DataSource = dtb;
                odr1.Close();

                ocon.Close();
                MessageBox.Show("Added Successfully");
                comboBox1.Text = comboBox2.Text = textBox1.Text = dateTimePicker1.Text = textBox3.Text = textBox4.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "Select matriC,depart,dateDepart,arrive,PeriodParJour from Destinations where matriV ='" + comboBox1.SelectedItem + "' ";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    comboBox2.Text = odr[0].ToString();
                    textBox1.Text = odr[1].ToString();
                    dateTimePicker1.Text = odr[2].ToString();
                    textBox3.Text = odr[3].ToString();
                    textBox4.Text = odr[4].ToString();
                    
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

        private void button7_Click(object sender, EventArgs e)
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
                ocom.CommandText = " delete from  Destinations  where  matriV = '" + comboBox1.Text + "'";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from Destinations";
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }




        /*  private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
          {
              //e.Graphics.DrawImage(bmp, 0, 0);
          }*/



        /* Bitmap bmp;*/

        private void DataShow_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox3.Text == "" || dateTimePicker1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }
            else
            {
                ocom = new SqlCommand("select * from Destinations where matriV='" + comboBox1.Text+ "'", ocon);
                SqlDataAdapter dat = new SqlDataAdapter(ocom);
                dat.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Matricule" + comboBox1.Text + "Cette vehicule est deje en mission" );
                    ds.Clear();
                }
                else
                {
                    try
                    {
                        ocon.Open();
                        ocom.Connection = ocon;
                        ocom.CommandText = "insert into Destinations (matriV,matriC,depart,arrive,dateDepart,PeriodParJour) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "')";
                        ocom.ExecuteNonQuery();


                        ocom1.Connection = ocon;
                        ocom1.CommandText = "select * from Destinations";
                        odr1 = ocom1.ExecuteReader();
                        DataTable dtb = new DataTable();
                        dtb.Load(odr1);
                        dataGridView1.DataSource = dtb;
                        odr1.Close();

                        ocon.Close();
                        MessageBox.Show("Added Successfully");
                        comboBox1.Text = comboBox2.Text = textBox1.Text = textBox3.Text = dateTimePicker1.Text = textBox4.Text = "";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);

                    }
                }
            }

           /* Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics ng = Graphics.FromImage(bmp);
            ng.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();*/
        }
    }
}

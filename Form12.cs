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
    public partial class Form12 : Form
    {
        public SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlDataReader odr, odr1;
        public SqlTransaction otr;
        public DataSet ds = new DataSet();
        public Form12()
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
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""||textBox6.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }
            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = " update Utilisateurs set  Nmatricule ='" + textBox1.Text + "',nom ='" + textBox2.Text + "',prenom='" + textBox3.Text + "',AdressMail='" + textBox4.Text + "',ntele='" + textBox5.Text + "',mtp='" + textBox6.Text + "' where Nmatricule = '" + comboBox1.Text + "' ";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from Utilisateurs";
                odr1 = ocom1.ExecuteReader();
                DataTable dtb = new DataTable();
                dtb.Load(odr1);
                dataGridView1.DataSource = dtb;
                odr1.Close();

                ocon.Close();
                MessageBox.Show("Added Successfully");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            try
            {

                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "select Nmatricule from Utilisateurs ";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    comboBox1.Items.Add(odr["Nmatricule"]);
                }
                odr.Close();
                ocon.Close();
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
                ocom.CommandText = "Select Nmatricule,nom,prenom,AdressMail,ntele,mtp from Utilisateurs where Nmatricule='" + comboBox1.SelectedItem + "' ";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    textBox1.Text = odr[0].ToString();
                    textBox2.Text = odr[1].ToString();
                    textBox3.Text = odr[2].ToString();
                    textBox4.Text = odr[3].ToString();
                    textBox5.Text = odr[4].ToString();
                    textBox6.Text = odr[5].ToString();

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""||textBox6.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }
            else
            {
                ocom = new SqlCommand("select * from Utilisateurs where Nmatricule='" + textBox1.Text + "'", ocon);
                SqlDataAdapter dat = new SqlDataAdapter(ocom);
                dat.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Matricule" + textBox1.Text + "est deja existe");
                    ds.Clear();
                }
                else
                {
                    try
                    {
                        ocon.Open();
                        ocom.Connection = ocon;
                        ocom.CommandText = "insert into Utilisateurs (Nmatricule,nom,prenom,AdressMail,ntele,mtp) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                        ocom.ExecuteNonQuery();


                        ocom1.Connection = ocon;
                        ocom1.CommandText = "select * from Utilisateurs";
                        odr1 = ocom1.ExecuteReader();
                        DataTable dtb = new DataTable();
                        dtb.Load(odr1);
                        dataGridView1.DataSource = dtb;
                        odr1.Close();

                        ocon.Close();
                        MessageBox.Show("Added Successfully");
                        textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);

                    }
                    new Form14().Show();
                    this.Hide();
                }
            }
        }
    }
}

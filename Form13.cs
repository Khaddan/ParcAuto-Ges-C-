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
    public partial class Form13 : Form
    {
        public SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlDataReader odr, odr1;
        public SqlTransaction otr;
        public DataSet ds = new DataSet();
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }
            else
            {
                ocom = new SqlCommand("select * from Clients where ref='" + textBox1.Text + "'", ocon);
                SqlDataAdapter dat = new SqlDataAdapter(ocom);
                dat.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("reference" + textBox1.Text + "est deja existe");
                    ds.Clear();
                }
                else
                {
                    try
                    {
                        ocon.Open();
                        ocom.Connection = ocon;
                        ocom.CommandText = "insert into Clients (ref,nom,prénom,mail,tel,societe,ville) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                        ocom.ExecuteNonQuery();


                        ocom1.Connection = ocon;
                        ocom1.CommandText = "select * from Clients";
                        odr1 = ocom1.ExecuteReader();
                        DataTable dtb = new DataTable();
                        dtb.Load(odr1);
                        dataGridView1.DataSource = dtb;
                        odr1.Close();

                        ocon.Close();
                        MessageBox.Show("Added Successfully");
                        textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);

                    }
                }
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            try
            {

                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "select ref from Clients ";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    comboBox1.Items.Add(odr["ref"]);
                }
                odr.Close();
                ocon.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }
            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = " update Clients set  ref ='" + textBox1.Text + "',nom ='" + textBox2.Text + "',prénom='" + textBox3.Text + "',mail='" + textBox4.Text + "',tel='" + textBox5.Text + "',societe='" + textBox6.Text + "',ville='" + textBox7.Text + "' where ref = '" + comboBox1.Text + "' ";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from Clients";
                odr1 = ocom1.ExecuteReader();
                DataTable dtb = new DataTable();
                dtb.Load(odr1);
                dataGridView1.DataSource = dtb;
                odr1.Close();

                ocon.Close();
                MessageBox.Show("Added Successfully");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
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
                ocom.CommandText = "Select ref,nom,prénom,mail,tel,societe,ville from Clients where ref='" + comboBox1.SelectedItem + "' ";
                odr = ocom.ExecuteReader();
                while (odr.Read())
                {
                    textBox1.Text = odr[0].ToString();
                    textBox2.Text = odr[1].ToString();
                    textBox3.Text = odr[2].ToString();
                    textBox4.Text = odr[3].ToString();
                    textBox5.Text = odr[4].ToString();
                    textBox6.Text = odr[5].ToString();
                    textBox7.Text = odr[6].ToString();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

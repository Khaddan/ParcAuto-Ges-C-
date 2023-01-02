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
using ClosedXML.Excel;

namespace Ges_PARCAUTO
{
    public partial class Form9 : Form
    {
        public SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlDataReader odr, odr1;
        public SqlTransaction otr;
        public Form9()
        {
            InitializeComponent();
        }

       /* private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == false)
                groupBox1.Visible = false;
        }*/

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'aUTOPCDataSet.Frais'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.fraisTableAdapter.Fill(this.aUTOPCDataSet.Frais);
            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "select N_Matricule from Conducteurs";
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


            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "select Matricule from Véhicules";
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

        private void btn1_Click(object sender, EventArgs e)
        {
        

            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }

          /*  string value = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = radioButton1.Text;
            else
                value = radioButton2.Text;*/

            try
            {
                ocon.Open();
                ocom.Connection = ocon;
                ocom.CommandText = "insert into  Frais (matriV,N_Matricule,F_Carburant,F_Autoroute,F_Depla,Deja_Repa,F_reparation) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox3.Text + "','" + textBox4.Text + "')";
                ocom.ExecuteNonQuery();


                ocom1.Connection = ocon;
                ocom1.CommandText = "select * from Frais";
                odr1 = ocom1.ExecuteReader();
                DataTable dtb = new DataTable();
                dtb.Load(odr1);
                dataGridView1.DataSource = dtb;
                odr1.Close();

                ocon.Close();
                MessageBox.Show("Added Successfully");
                comboBox1.Text = comboBox2.Text = textBox1.Text = textBox2.Text = textBox3.Text = comboBox3.Text = textBox4.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook |*.xlsx"})
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        using(XLWorkbook workbook = new XLWorkbook() )
                        {
                           // workbook.Worksheets.Add(this.aUTOPCDataSet.Frais.CopyToDataTable(), "Frais");
                           // workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Vous avez réussi à exporter vos données vers un fichier excel", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
        public void VIDER(Control f)
        {
            foreach (Control ct in f.Controls)
            {
                if (ct.GetType() == typeof(TextBox))
                {
                    ct.Text = "";
                }
                if (ct.GetType() == typeof(ComboBox))
                {
                    ct.Text = "";
                }
                if (ct.Controls.Count != 0)
                {
                    VIDER(ct);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vider les champs ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Form11().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       /* private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
                groupBox1.Visible = true;
            
        }*/
       /* string value = "";
        bool isChecked = radioButton1.Checked;
       if(isChecked )
          value = radioButton1.Text;
           else
        value=radioButton2.Text;*/
         
    }
}

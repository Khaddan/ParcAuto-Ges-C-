using ClosedXML.Excel;
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
    public partial class Form10 : Form
    {
        public SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlDataReader odr, odr1;
        public SqlTransaction otr;
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook |*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.aUTOPCDataSet3.Frais.CopyToDataTable(), "Frais");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Vous avez réussi à exporter vos données vers un fichier excel", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'aUTOPCDataSet3.Frais'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fraisTableAdapter.Fill(this.aUTOPCDataSet3.Frais);
           
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

        private void button2_Click(object sender, EventArgs e)
        {

            /* int cmp = 0;
             for(int i =0;i<this.dataGridView1.Rows.Count-1;i++)
             {
                 if(this.dataGridView1.Rows[i].Cells[6].Value.ToString()== this.textBox1.Text)
                 {
                     MessageBox.Show("il existe !!");
                     cmp = 1;
                 }
             }
             if (cmp == 0)
                 MessageBox.Show("n'existe pas");*/
            /* try
             {

                 ocon.Open();
                 ocom.Connection = ocon;
                 ocom.CommandText = "Select matriV,N_Matricule,F_Carburant,F_Autoroute,F_Depla,Deja_Repa,F_reparation from Frais where id ='" + textBox1.Text+ "' ";
                 odr = ocom.ExecuteReader();
                 while (odr.Read())
                 {
                      odr[0].ToString();
                      odr[1].ToString();
                      odr[2].ToString();
                      odr[3].ToString();
                      odr[4].ToString();
                      odr[5].ToString();
                      odr[6].ToString();
                 }

                 odr.Close();
                 ocon.Close();
                 //MessageBox.Show("successfuly");
             }
             catch (Exception EX)
             {
                 MessageBox.Show(EX.Message);
             }*/
            int nbrFois = 0;
            int index = 0;
            if(dataGridView1 != null)
            {
                for(int i=0;i<dataGridView1.Rows.Count;i++)
                {
                    foreach(DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if(cell.Value != null && (cell.Value.ToString().IndexOf(textBox1.Text.ToString()))>0)
                        {
                            nbrFois += 1;
                            cell.Style.BackColor = Color.RoyalBlue;
                        }
                    }
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

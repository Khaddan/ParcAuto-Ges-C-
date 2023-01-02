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
using System.Text.RegularExpressions;

//using System.IO;

namespace Ges_PARCAUTO
{
    public partial class Form2 : Form
    {
       public SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlDataReader odr, odr1;
        public SqlTransaction otr;
        public DataSet ds = new DataSet();
        
        
        //public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        // public event UpdateDelegate UpdateEventHandler;



        public Form2()
        {
            InitializeComponent();
        }
        // ADO d = new ADO();



        //Declaration de la methode nombre

       /* public int nombre()
        {




            int cpt;
            ocom.CommandText = "select count(idConducteur) from Conducteurs where idCinducteur = '" + textB1.Text + "'";
            ocom.Connection = ocon;
            cpt = Convert.ToInt32(ocom.ExecuteScalar());
            return cpt;





        }*/
        //Declaration de la methode ajouter
        /*public bool AJOUTER()
        {
            
            try
            {

                    ocon.Open();
                    ocom.CommandText = "insert into Conducteurs (nom,prénom,N_Matricule,adresse,type_permis,dateExipationPermis,dateNaissance) values ('" + textB1.Text + "','" + textB2.Text + "','" + textB3.Text + "','" + textB4.Text + "','" + textB5.Text + "','" + textB6.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
                    ocom.Connection = ocon;
                    ocom.ExecuteNonQuery();
                    ocon.Close();
                    return true;

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }*/

                private void closebtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez vous quitter ?","Confirmation",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
                this.Close();
            }
        }

        

        /* string testObligatoire()
       {

           {
               if (textB1.Text == "Nom Complet Chauffeur" || textB1.Text == "")
               {
                   return "Entrer Le Nom Complet du Chauffeur";
               }
               if (textB2.Text == "Telephone de Chauffeur" || textB2.Text == "")
               {
                   return "Entrer Le Telephone du Chauffeur";
               }
               if (textB3.Text == "Adresse de Chauffeur")
               {
                   return "Entrer L'adresse du Chauffeur";
               }
               if (textB4.Text == "N_Permis de Chauffeur" || textB4.Text == "")
               {
                   return "Entrer Le Numeros de Permis du Chauffeur";
               }
               if (textB5.Text == "N_CIN Chauffeur" || textB5.Text == "")
               {
                   return "Entrer Le CIN du Chauffeur";
               }

           }*/
        //}

        // REMPLISSAGE DE DATAGRIDVIEW
       /* public void RemplirGrid()
        {
            DataTable dtb = new DataTable();
            if (dtb.Rows != null)
            {
                dtb.Clear();
            }
            ocom1.Connection = ocon;
            ocom1.CommandText = "select * from Véhicules";
            odr1 = ocom1.ExecuteReader();
            dtb.Load(odr1);
            dataGridView1.DataSource = dtb;
            odr1.Close();
        }*/
        //Methode de vider

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

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
           // d.CONNECTER();
          // RemplirGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        /* private void textB1_TextChanged(object sender, EventArgs e)
         {
             if (textB1.Text == "Nom Complet Chauffeur" )
             {
                 textB1.Text = "";

             }
         }

       /*  private void textB2_TextChanged(object sender, EventArgs e)
         {
             if (textB2.Text == "Nom Complet Chauffeur")
             {
                 textB2.Text = "";

             }
         }

       /*  private void textB4_TextChanged(object sender, EventArgs e)
         {
             if (textB4.Text == "Numero du matricule")
             {
                 textB4.Text = "";

             }
         }

         private void textB5_TextChanged(object sender, EventArgs e)
         {
             if (textB5.Text == "Mot de passe")
             {
                 textB5.Text = "";

             }
         }*/

        private void btn1_Click(object sender, EventArgs e)
        {

            if (textB2.Text == "" || textB3.Text == "" || textB4.Text == "" || textB5.Text == "" || textB6.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "")
            {
                MessageBox.Show("Merci de remplir tout les champs");
                return;
            }
            else
            {
                ocom = new SqlCommand("select * from Conducteurs where N_Matricule='" + textB4.Text + "'", ocon);
                SqlDataAdapter da = new SqlDataAdapter(ocom);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Matricule" + textB4.Text + "Exist deja");
                    ds.Clear();
                }

                else
                {


                    try
                    {


                        ocon.Open();
                        ocom.Connection = ocon;
                        ocom.CommandText = "insert into  Conducteurs (nom,prénom,N_Matricule,adresse,type_permis,dateExipationPermis,dateNaissance) values ('" + textB2.Text + "','" + textB3.Text + "','" + textB4.Text + "','" + textB5.Text + "','" + textB6.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
                        ocom.ExecuteNonQuery();


                        ocom1.Connection = ocon;
                        ocom1.CommandText = "select * from Conducteurs";
                        odr1 = ocom1.ExecuteReader();
                        DataTable dtb = new DataTable();
                        dtb.Load(odr1);
                        dataGridView1.DataSource = dtb;
                        odr1.Close();

                        ocon.Close();
                        MessageBox.Show("Added Successfully");
                        textB2.Text = textB3.Text = textB4.Text = textB5.Text = textB6.Text = dateTimePicker1.Text = dateTimePicker2.Text = "";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);

                    }
                }
            }
           
            /* if (textB1.Text == "" || textB2.Text == "" || textB3.Text == "" || textB4.Text == "" || textB5.Text == "" || textB6.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "" )
             {
                 MessageBox.Show("Merci de remplir tout les champs");
                 return;
             }
             try
             {

                 ocon.Open();
                 ocom.CommandText = "insert into  Conducteurs (nom,prénom,N_Matricule,adresse,type_permis,dateExipationPermis,dateNaissance) values ('" + textB1.Text + "','" + textB2.Text + "','" + textB3.Text + "','" + textB4.Text + "','" + textB5.Text + "','" + textB6.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
                 ocom.Connection = ocon;
                 ocom.ExecuteNonQuery();
                 ocon.Close();
                 ocom1.Connection = ocon;
                 ocom1.CommandText = "select * from Conducteurs";
                 odr1 = ocom1.ExecuteReader();
                 DataTable dtb = new DataTable();
                 dtb.Load(odr1);
                 dataGridView1.DataSource = dtb;
                 odr1.Close();

                 ocon.Close();
                 MessageBox.Show("Added Successfully");
                 textB1.Text = textB2.Text = textB3.Text = textB4.Text = textB5.Text = textB6.Text = dateTimePicker1.Text= dateTimePicker2.Text= "";




             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/



            /* try
             {
                //errorProvider1.Dispose();
                 ocon.Open();
                 ocom.Connection = ocon;
                 ocom.CommandText = "insert into Utilisateurs  values ('" + textB1.Text + "','" + textB2.Text + "','" + textB3.Text + "','" + textB4.Text + "','" + textB5.Text + "')";
                 ocom.ExecuteNonQuery();
                 ocon.Close();
                 //MessageBox.Show( "Merci de remplir tous les champs");

             }

             catch (Exception Ex)
             {
                 //errorProvider1.SetError(this.textB1,Ex.Message);
                 MessageBox.Show(Ex.Message);
             }*/














        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textB6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textB5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textB4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vider les champs ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }
        }
    }
}

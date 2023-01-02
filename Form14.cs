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
    public partial class Form14 : Form
    {
        public SqlConnection ocon = new SqlConnection(@"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True");
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        public SqlDataReader odr, odr1;
        public SqlTransaction otr;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da = new SqlDataAdapter();
        public Form14()
        {
            InitializeComponent();
        }
        string testObligatoire()
        {
            if (textBox1.Text == "Login" || textBox1.Text == "")
            {
                return "Saisie Login";
            }
            if (textBox2.Text == "Mot de passe" || textBox2.Text == "")
            {
                return "Saisie Le Mot de Passe";
            }
            return null;
        }

        private void Form14_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Utilisateurs where nom='" + textBox1.Text + "' and mtp='" + textBox2.Text + "'",ocon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                Form3 fr = new Form3();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Merci de verifier Nom et mot de passe");
            }
            

        }
           
}   }
    

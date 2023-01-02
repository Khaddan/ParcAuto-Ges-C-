using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ges_PARCAUTO
{
    internal class ADO
    {
        //Declaration des Objets Sql
        public SqlConnection ocon = new SqlConnection();
        public SqlCommand ocom = new SqlCommand();
        public SqlCommand ocom1 = new SqlCommand();
        //public SqlDataReader dr;

        public DataTable dt = new DataTable();

        //Declaration de la methode connecter
        public void CONNECTER()
        {
            if(ocon.State==ConnectionState.Open || ocon.State == ConnectionState.Broken)
            {
                ocon.ConnectionString = @"Data Source=DESKTOP-1FNA1GH;Initial Catalog=AUTOPC;Integrated Security=True";
                ocon.Open();
            }
        }
        //Declaration de la methode deconnecter
        public void DECONNECTER()
        {
            if(ocon.State==ConnectionState.Open)
            {
                ocon.Close();
            }
        }

    }
}

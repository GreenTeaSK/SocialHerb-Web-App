using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebAppHerb.Models
{
    

    public class ServiceHerb
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\v11.0;Initial Catalog=WebAppHerbDB;Persist Security Info=True;User ID=admin;Password=admin; Integrated Security=True; MultipleActiveResultSets=True;");

        public string Test(string nameHerb)
        {
            connection.Open();
            SqlCommand herb = new SqlCommand("SELECT * FROM Herbs WHERE herbName ='" + nameHerb + "'", connection);
            SqlDataReader dr = herb.ExecuteReader();

            while (dr.Read())
            {
                nameHerb = dr["herbName"].ToString();
                string detail = dr["herbDetail"].ToString();
                string prop = dr["herbProperties"].ToString();
            }
            dr.Close();
            connection.Close();

            return nameHerb;
        }
    }
}
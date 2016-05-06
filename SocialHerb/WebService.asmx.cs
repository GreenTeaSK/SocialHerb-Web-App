﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;
using SocialHerb.Models;
using SocialHerb;


namespace SocialHerb
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class WebService : System.Web.Services.WebService
    {
       
                [WebMethod]
        public DataTable Herb(string herbName)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataAdapter dtAdapter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            DataTable dt = null;
           // string strConnString = null;
            StringBuilder strSQL = new StringBuilder();

            /*function OpenConnection() as Boolean
            try {

                SqlConnection sqlConn = new SqlConnection("Data Source=(LocalDb)\v11.0;Initial Catalog=HerbDB;Persist Security Info=True;User ID=admin;Password=admin; Integrated Security=True; MultipleActiveResultSets=true;Pooling = false");
                return true;
              }
            catch {
                return false;
               }*/



            strSQL.Append(" SELECT * FROM Herb ");
            strSQL.Append(" WHERE [herbName] = '" + herbName + "' ");
            string SqlConnection = null;
            objConn.ConnectionString = SqlConnection;
            var _with1 = objCmd;
            _with1.Connection = objConn;
            _with1.CommandText = strSQL.ToString();
            _with1.CommandType = CommandType.Text;
            dtAdapter.SelectCommand = objCmd;
            dtAdapter.Fill(ds);
            dt = ds.Tables[0];
            dtAdapter = null;
            objConn.Close();
            objConn = null;

            return dt;
            }
    }
}

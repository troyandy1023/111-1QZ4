﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting.Contexts;


namespace _111_1QZ4
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_ConnS = "";

            s_ConnS = "Data Source=(localdb)\\ProjectModels;" +
                "Initial Catalog=Test;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" +
                "User ID = sa; Password = 12345";



            try
            {
                SqlConnection o_Conn = new SqlConnection(s_ConnS);
                SqlCommand o_Com = new SqlCommand("select * from Users",o_Conn);
                o_Conn.Open();
                SqlDataReader o_R = o_Com.ExecuteReader();
                for (; o_R.Read();)
                {
                    for (int i_Col = 0; i_Col < o_R.FieldCount; i_Col++)
                    {
                        Response.Write("&nbsp;&nbsp;" + o_R[i_Col].ToString());
                    }
                    Response.Write("<br />");
                }
                o_Conn.Close();
            }
            catch (Exception o_Exc)
            {
                Response.Write(o_Exc.ToString());
            }
        }
    }
}
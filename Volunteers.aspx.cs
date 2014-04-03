using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NVC
{
    public partial class Volunteers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowVolunteers();
        }

        private string GetConnectionString()
        {
            String connString = "DATA SOURCE=NVC;PASSWORD=VIPA;USER ID=VIPA;";
            return connString;
        }
        protected void ShowVolunteers()
        {
            string connectionString = GetConnectionString();

           

            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                OracleCommand command = connection.CreateCommand();
                string sql = @"SELECT FNAME AS ""FIRST NAME"",LNAME AS ""LAST NAME"",DEGIGNATION AS ""DESIGNATION"",ADDR AS ""ADDRESS"", TEL1, TEL2,EMAIL,CASE SEX WHEN 'M' THEN 'MALE' ELSE 'FEMALE' END AS ""GENDER"",SERVED AS ""COURSES SERVED""  FROM T_VOLUNTEER ORDER BY FNAME";

                command.CommandText = sql;
           
                OracleDataReader reader = command.ExecuteReader();
                gvVolunteers.DataSource = reader;
                gvVolunteers.DataBind();
            }
        }
    }
}
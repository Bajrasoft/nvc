using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NVC
{
    public partial class Teachers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strDesignation = string.Empty;
          
          strDesignation = Convert.ToString(Request.QueryString["Designation"]);


          ShowTeachers(strDesignation);
        }

        private string GetConnectionString()
        {
            String connString = "DATA SOURCE=NVC;PASSWORD=VIPA;USER ID=VIPA;";
            return connString;
        }
        protected void ShowTeachers(string strDesignation)
        {
            string connectionString = GetConnectionString();
           
           switch(strDesignation)
           {
               case "T":
                    lblGridTitle.InnerText = "Teachers List";
                   break;
               case "SAT":
                    lblGridTitle.InnerText = "Sr. AT List";
                   break;
               case "AT":
                   lblGridTitle.InnerText = "AT List";
                   break;
               default:
                   lblGridTitle.InnerText = "Teachers List";
                   break;


           }
           
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                OracleCommand command = connection.CreateCommand();
                string sql = @"SELECT FNAME AS ""FIRST NAME"",MNAME AS ""MIDDLE NAME"",LNAME AS ""LAST NAME"",DEGIGNATION AS ""DESIGNATION"",ADDR AS ""ADDRESS"", TEL1, TEL2,EMAIL,CASE SEX WHEN 'M' THEN 'MALE' ELSE 'FEMALE' END AS ""GENDER"" FROM T_TEACHER WHERE (:pDesignation IS NULL OR DEGIGNATION LIKE :pDesignation) ORDER BY FNAME,LNAME,DEGIGNATION,SEX";

                OracleParameter pDesignation = new OracleParameter();
                pDesignation.OracleDbType = OracleDbType.Varchar2;
                pDesignation.Value = strDesignation;

                command.CommandText = sql;
                command.Parameters.Add(pDesignation);

                OracleDataReader reader = command.ExecuteReader();
                gvTeachers.DataSource = reader;
                gvTeachers.DataBind();
            }
        }
    }
}
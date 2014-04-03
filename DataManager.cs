using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Oracle.ManagedDataAccess.Client;
namespace NVC
{
    public static class DataManager 
    {
        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
       // public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}

        private static string GetConnectionString()
        {
            String connString = "DATA SOURCE=NVC;PASSWORD=VIPA;USER ID=VIPA;";
            return connString;
        }

       

        public static Dictionary<string,string> GetStats(string strQuery)
        {

            Dictionary<string, string> dtStats = new Dictionary<string, string>(); ;
           
            string connectionString = GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                OracleCommand command = connection.CreateCommand();
                //  string sql = @"SELECT TRAIN_S_N AS ""Course No"",TO_CHAR(START_DATE,'MON-DD-YYYY') AS ""Start Date"",TO_CHAR(TILL_DATE,'MON-DD-YYYY') AS ""End Date"",APP_FNAME AS ""First Name"",APP_LNAME AS ""Last Name"", APP_AGE AS ""Age"",APP_HPH_NO AS ""Home Phone"",APP_OPH_NO AS ""Other Phone"",APP_EMAIL AS ""Email"",APP_ADDR AS ""Address"",APP_BUSINESS AS ""Occupation"", OLD_Y_N AS ""Old"",COURSE_TYPE AS ""Course Type"" FROM T_Application WHERE START_DATE> CURRENT_DATE ORDER BY START_DATE,APP_FNAME";
                command.CommandText = strQuery;


              OracleDataReader  reader = command.ExecuteReader();
              while (reader.Read())
              {
                  dtStats.Add(reader[0].ToString(), reader[1].ToString());
              }

            }
            return dtStats;
        }

        //
    }
}
using ActiveUp.Net.Mail;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace NVC
{
    public partial class _Default : Page
    {
        public static Imap4Client imap;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                GetStats();
                //if (imap == null)
                //{
                //    imap = new Imap4Client();
                //    imap.ConnectSsl("imap.gmail.com", 993);
                //    imap.Login(@"dhammashringaxml@gmail.com", @"dhamma@xml");

                //    imap.Command("capability");
                //    imap.LingerState.Enabled = true;
                //    imap.LingerState.LingerTime = 2000;


                //}
                //Mailbox inbox = imap.SelectMailbox("Applications");
                //int[] ids = inbox.Search("UNSEEN");
                //lblNo.Text = ids.Count().ToString();
            }
            catch (Exception ex)
            {

            }

        }

        public void initNotify(string StrSplash)
        {
            // Only do this on the first call to the page
            if ((!IsCallback) && (!IsPostBack))
            {
                //Register loadingNotifier.js for showing the Progress Bar
                Response.Write(string.Format(@"<script type='text/javascript'  src='Scripts/loadingNotifier.js'></script><script language='javascript' type='text/javascript'>initLoader('{0}');</script>", StrSplash));
                // Send it to the client
                Response.Flush();

            }

        }

        public void Notify(string strPercent, string strMessage)
        {
            // Only do this on the first call to the page
            if ((!IsCallback) && (!IsPostBack))
            {
                //Update the Progress bar

                Response.Write(string.Format(@"<script language='javascript' type" + "='text/javascript'>setProgress({0},'{1}'); </script>", strPercent, strMessage));
                Response.Flush();
            }
        }

        public void GetStats()
        {
            

            string strQuery = @"SELECT COUNT(T_TEACHER.DEGIGNATION) AS ""Total"",
                               -- CASE
                                T_TEACHER.DEGIGNATION 
                               -- WHEN 'T' THEN 'Teachers' WHEN  'SAT' THEN 'Senior AT'  ELSE 'Assitant Teacher' END AS ""Desc""
                                FROM VIPA.T_TEACHER  WHERE DEGIGNATION IS NOT NULL GROUP BY DEGIGNATION
                                UNION
                                SELECT Count(1),'Volunteers' FROM T_VOLUNTEER
                                UNION
                                SELECT Count(APP_ADDR), 'Students'  FROM VIPA.T_APPLICATION ";
             Dictionary<string, string> dtStats = DataManager.GetStats(strQuery);

             foreach (KeyValuePair<string, string> item in dtStats)
             {

                 switch (item.Value)
                 {
                     case "T":
                         lblTeachers.Text = item.Key;
                         break;
                     case "SAT":
                         lblSat.Text = item.Key;
                         break;
                     case "AT":
                         lblAt.Text = item.Key;
                         break;
                     case "Students":
                         lblStudents.Text =item.Key;
                         break;
                     case "Volunteers":
                         lblVolunteers.Text = item.Key;
                         break;
                 }
                
                
             }            
        }
    }
}
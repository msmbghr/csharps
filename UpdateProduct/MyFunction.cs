using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace UpdateProduct
{
   public class MyFunction
    {
        string connetionString = null;
        public int MYConnection(string username,string pass)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"GetInfo.xml");
            int Good = 0;
            string Servername = xmldoc.SelectSingleNode("Settings/Servername").InnerText;
            string DatabaseName = xmldoc.SelectSingleNode("Settings/DatabaseName").InnerText;
            string sql = null;
            connetionString = "Data Source="+ Servername + ";Initial Catalog="+ DatabaseName + ";User ID=sa;Password=sac-100";
            SqlConnection cnn;
            SqlCommand command;
            cnn = new SqlConnection(connetionString);
            sql = "select user_name,user_password from sys_users where user_name='" + username + "'and user_password='" + pass + "'";
            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                   // MessageBox.Show("Login sucess Welcome to Homepage ");
                    Good = 1;
                }
                else
                {
                    MessageBox.Show(" نام كاربري يا كلمه ورود را اشتباه وارد كرديد");
                }
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Good;
        }

        public  string stringconnect()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"GetInfo.xml");
            string Servername = xmldoc.SelectSingleNode("Settings/Servername").InnerText;
            string DatabaseName = xmldoc.SelectSingleNode("Settings/DatabaseName").InnerText;
            return connetionString = "Data Source=" + Servername + ";Initial Catalog=" + DatabaseName + ";User ID=sa;Password=sac-100";
        }



    }
}

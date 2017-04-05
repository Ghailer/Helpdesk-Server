using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Helpdesk_Server
{
    class SQLCommands
    {
        SqlConnection connection;

        public SQLCommands(SqlConnection connection)
        {
            this.connection = connection;
        }



        private void AddUser(string user)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username) VALUES (@Username)");
            cmd.Parameters.AddWithValue("@Username", user);
        }



        /*
          SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + @"C:\Users\Rafal.Szmajser\Documents\Visual Studio 2017\Projects\Helpdesk\Helpdesk\helpdeskDB.mdf" + "; Integrated Security = True");
          connection.Open();

          SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username) VALUES (@Username)");
          cmd.CommandType = System.Data.CommandType.Text;
          cmd.Connection = connection;
          cmd.Parameters.AddWithValue("@Username", "rafal.szmajser");
          connection.Open();
          cmd.ExecuteNonQuery();*/

    }
}

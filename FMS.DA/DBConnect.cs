using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FMS.DA
{
    class DBConnect
    {
        static void Connect(string[] args)
        {
            using (SqlConnection connString = new SqlConnection())
            {

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                Connection();
                void Connection()
                {
                    string instance = "sps-soft-hg\\exp_2012";
                    string dbname = "FMS";
                    string username = "sa";
                    string password = "Shohaymi!2";

                    builder["Data Source"] = instance;
                    builder["Integrated Security"] = false;
                    builder["Initial Catalog"] = dbname;
                    builder["User ID"] = username;
                    builder["Password"] = password;

                    Console.WriteLine(builder.ConnectionString);

                    connString.ConnectionString = builder.ConnectionString;
                }
            }
        }
    }
}

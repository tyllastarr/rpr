namespace RPR
{

    using System;
    using System.IO;
    using System.Data;
    using Newtonsoft.Json;
    using MySql.Data;
    using MySql.Data.MySqlClient;
    using db;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DBConnection conn = new DBConnection();
            string connString = File.ReadAllText(@"..\..\..\db\dbconfig.json");
            conn = JsonConvert.DeserializeObject<DBConnection>(connString);
            connString = conn.OutputConnString();
            MySqlConnection mySqlConn = new MySqlConnection(connString);
            try
            {
                Console.WriteLine("Opening the connection...");
                mySqlConn.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            mySqlConn.Close();
            Console.WriteLine("This seems to work.");
        }
    }
}

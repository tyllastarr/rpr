namespace RPR
{

    using System;
    using System.IO;
    using System.Data;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using MySql.Data;
    using MySql.Data.MySqlClient;
    using db;

    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            // Connect to MySQL database
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

            // Create character variable
            Character myChar = new Character();

            // Roll origin
            try
            {
                string cmdStr = "SELECT * FROM origins";
                MySqlCommand cmd = new MySqlCommand(cmdStr, mySqlConn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                Queue<DBItem> results = new Queue<DBItem>();
                while(rdr.Read())
                {
                    results.Enqueue(new DBItem(rdr[1].ToString(), (int)rdr[0]));
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();
                int index = rand.Next(results.Count);
                DBItem dump; // For debug use only

                for(int i = 0; i < index; i++)
                {
                   dump = results.Dequeue();  // Dump this item 
                   Console.WriteLine($"Dumping {dump.ItemName}");
                }

                myChar.Origin = results.Dequeue();
                Console.WriteLine($"Keeping {myChar.Origin.ItemName}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // Roll archetype and alignment
            try
            {
                string cmdStr = "SELECT * FROM archetypes";

                MySqlCommand cmd = new MySqlCommand(cmdStr, mySqlConn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                Queue<Archetype> results = new Queue<Archetype>();
                while (rdr.Read())
                {
                    results.Enqueue(new Archetype(rdr[1].ToString(), (int)rdr[0], (bool)rdr[2], (bool)rdr[3], (bool)rdr[4]));
                    Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2] + " -- " + rdr[3] + " -- " + rdr[4]);
                }
                rdr.Close();
                int index = rand.Next(results.Count);
                Archetype dump; // For debug use only

                for (int i = 0; i < index; i++)
                {
                    dump = results.Dequeue();  // Dump this item 
                    Console.WriteLine($"Dumping {dump.Item.ItemName}");
                }

                Archetype temp = results.Dequeue();
                myChar.Archetype = temp.Item;
                Console.WriteLine($"Keeping {temp.Item.ItemName}");

                bool ATCorrect = false;
                Alignment newAlign;
                do
                {
                    newAlign = (Alignment)rand.Next(3);
                    switch(newAlign) {
                        case Alignment.Hero:
                            ATCorrect = temp.Hero;
                            break;
                        case Alignment.Villain:
                            ATCorrect = temp.Villain;
                            break;
                        case Alignment.Praetorian:
                            ATCorrect = temp.Praetorian;
                            newAlign = (Alignment)(rand.Next(2) + 3);
                            break;
                    }
                } while (ATCorrect == false);
                myChar.Align = newAlign;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
 
        // Close connection
        mySqlConn.Close();
        }
    }
}

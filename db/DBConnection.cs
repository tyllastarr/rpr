using System;
using System.Collections.Generic;
using System.Text;

namespace RPR.db
{
    class DBConnection
    {
        public string server { get; set; }
        public string user { get; set; }
        public string database { get; set; }
        public int port { get; set; }
        public string password { get; set; }

        public string OutputConnString()
        {
            string output;
            output = $"server={server};user={user};database={database};port={port};password={password};";
            return output;
        }
    }
}

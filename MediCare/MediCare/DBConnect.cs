using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare
{
    class DBConnect
    {
        public string server, database, uid, password;

        public DBConnect(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            server = lines[0];
            database = lines[1];
            uid = lines[2];
            password = lines[3];
        }

        public override string ToString()
        {

            string connectionString;

            connectionString = "SERVER=" + server + ";DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            return connectionString;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoDesignPatterns.Patterns.Singleton
{
    public class DatabaseConnection
    {
       private static DatabaseConnection Instance { get; set; }
       public string ConnectionString { get; set; }

        private DatabaseConnection(string connectionString) 
       {
            ConnectionString = connectionString;
       }
       public static DatabaseConnection GetInstance()
        {
            if(Instance == null) 
                Instance = new DatabaseConnection("This is my connection string");

            return Instance;
        }
    }
}

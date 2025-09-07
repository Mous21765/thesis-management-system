using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public class Accounts
    {
        private string id;
        private string name;
        private string type;
        private string connectionString;
        private MySqlConnection connection;
        public Accounts()
        {
            connectionString = "server=localhost;uid=root;pwd=1234;database=ptyxiakes";
            connection = new MySqlConnection(connectionString);
        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }

        public int Login(string id,string password)
        {
            connection.Open();
            string q = "select * from accounts where(id='" + id + "' and password='" + password + "');";
            int isFound = 0;
            MySqlCommand command=new MySqlCommand(q,connection);
            MySqlDataReader r=command.ExecuteReader();
            string name = "";
            string category = "";
            while (r.Read())
            {
                name=r.GetString("name");
                category=r.GetString("category");
            }
            if (!string.IsNullOrEmpty(name))
            {
                this.id = id;
                this.name = name;
                this.type = category;
                isFound = 1;
            }
            connection.Close();
            return isFound;
        }
        public List<string[]> kathigites()
        {
            List<string[]> kathigites = new List<string[]>();
            string query = "select name,id from accounts where category='professor';";
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                string[] k = new string[2] { r.GetString("name"), r.GetString("id") };
                kathigites.Add(k);
            }
            connection.Close();
            return kathigites;
        }

    }
}
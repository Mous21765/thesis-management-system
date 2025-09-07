using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public class Ptyxiaki
    {
        private string id_foititi;
        private string id_kathigiti;
        private string title;
        private string description;
        private string connectionString;
        private MySqlConnection connection;
        public Ptyxiaki()
        {
            connectionString = "server=localhost;uid=root;pwd=1234;database=ptyxiakes";
            connection = new MySqlConnection(connectionString);
        }
        public int createPtyxiaki(string id_foititi,string id_kathigiti,string title,string description)
        {
            int result = 0;
            string exist_query = "select exists (select * from ptyxiaki where id_foititi='" + id_foititi + "');";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(exist_query, connection);
            MySqlDataReader r=cmd.ExecuteReader();
            while (r.Read())
            {
                result=r.GetInt32(0);
            }
            connection.Close();
            if (result == 1)
            {
                return 0;
            }
            else
            {
                string q = "insert into ptyxiaki values('" + id_foititi + "','" + id_kathigiti + "','" + title + "','" + description + "');";
                connection.Open();
                cmd = new MySqlCommand(q, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
            return 0;
        }
        public void upload_file(string id,string filename)
        {
            string query = "replace into files values('" + id + "','" + filename + "');";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<string[]> get_professor_ptyxiakes(string id)
        {
            List<string[]> ptyxiakes = new List<string[]>();
            string query = "select * from ptyxiaki inner join accounts on accounts.id = ptyxiaki.id_foititi where id_kathigiti = '" + id + "'; ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                string[] p = new string[3] { r.GetString("id_foititi"), r.GetString("title"), r.GetString("name") };
                ptyxiakes.Add(p);
            }
            connection.Close();
            return ptyxiakes;
        }
        public string[] get_ptyxiaki(string id)
        {
            string[] ptyxiaki = new string[3];
            connection.Open();
            string query = "select * from ptyxiaki where id_foititi='" + id + "';";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                ptyxiaki[0] = r.GetString("title");
                ptyxiaki[1] = r.GetString("description");
            }
            connection.Close();
            ptyxiaki[2] = "-";
            query = "select * from grades where student_id='" + id + "';";
            connection.Open();
            cmd = new MySqlCommand(query, connection);
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                ptyxiaki[2] = r.GetDouble("grade").ToString();
            }
            return ptyxiaki;
            connection.Close();
        }
    }
}
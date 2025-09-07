using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystimaDiaxeirisisPtyxiakwn
{
    public class Kathigitis
    {
        private string connectionString;
        private MySqlConnection connection;
        public Kathigitis()
        {
            connectionString = "server=localhost;uid=root;pwd=1234;database=ptyxiakes";
            connection = new MySqlConnection(connectionString);
        }
        public string getProfessorOfThesis(string student_id)
        {
            connection.Open();
            string query = "select id_kathigiti from ptyxiaki where id_foititi='" + student_id + "';";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader r = cmd.ExecuteReader();
            string id = "-";
            while (r.Read())
            {
                id = r.GetString("id_kathigiti");
            }
            connection.Close();
            return id;
        }

        public void CreateDate(string student_id,string teacher_id,string d)
        {
            connection.Open();
            string query = "insert into rantevou values('" + student_id + "','" + teacher_id + "','" + d + "');";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<string[]> GetDates(string id)
        {
            List <string[]> dates=new List<string[]>();
            string query = "select  * from rantevou inner join accounts where rantevou.foititis = accounts.id and kathigitis = '"+id+"' order by rantevou.date asc; ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] d = new string[2] { reader.GetString("name"), reader.GetDateTime("date").ToString() };
                dates.Add(d);
            }
            connection.Close();
            return dates;
        }
        public void GradeThesis(string id,double grade)
        {
            string query = "insert into grades values('" + id + "','" + grade.ToString() + "');";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
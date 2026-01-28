using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOReadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=HP\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

            string query = "select id , name ,age ,Marks from students";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("ID: " + reader["id"]);
                    Console.WriteLine("Name: " + reader["name"]);
                    Console.WriteLine("Age: " + reader["age"]);
                    Console.WriteLine("Marks: " + reader["Marks"]);
                    Console.WriteLine("----------------------------");
                }
            }
            Console.ReadLine();

        }
    }
}

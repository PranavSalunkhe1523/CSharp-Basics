using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODeleteExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=HP\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

            string query = "delete from students where id = 2";

            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                int rows = cmd.ExecuteNonQuery();

                Console.WriteLine(rows + " Record deleted successfully.");
            }
            Console.ReadLine();
        }
    }
}

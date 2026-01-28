using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ADOUpdateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=HP\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

            string query = "update students set Marks = 95 where id=1";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd= new SqlCommand(query, con);
                int rows = cmd.ExecuteNonQuery();

                Console.WriteLine(rows + "record updated successfully.");
            }
            Console.ReadLine();
        }
    }
}

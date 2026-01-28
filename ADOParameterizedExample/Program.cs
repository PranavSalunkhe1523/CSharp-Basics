using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOParameterizedExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=HP\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

            Console.WriteLine("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            string query = " insert into students (Id,name,age,Marks) values(@Id, @Name,@Age, @Marks )";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                 SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Marks", marks);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows + " record inserted successfully.");

            }
            Console.ReadLine();
        }
    }
}

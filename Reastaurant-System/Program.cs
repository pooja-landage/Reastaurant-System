using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RestaurantLogic;

namespace Reastaurant_System
{
    class Program
    {
        static SqlDataReader dr;
        static void Main(string[] args)
        {
            
            

            Console.WriteLine(" *********************************LOGIN FORM *************************** ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Enter User Name");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();
            Restaurant.Validation(username, pass);
            Console.ForegroundColor = ConsoleColor.White;

           

            Console.WriteLine(" ******************Connectivity ******************** ");
            string constr = "Data source=DESKTOP-FLCVG6T;initial catalog=Restaurant;user=sa;password=Pooja@2708";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = constr;

            Console.Write("\n");
           
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();

            con.Open();
            string query = "select Restname from Restaurant1 where RestStatus = 'y'";
            SqlCommand cmd = new SqlCommand(query, con);


            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ******************LIST OF ACTIVE RESTAURANT ******************** ");
            while (dr.Read())
            {
                Console.Write("\n{0}\n", dr[0]);
            }
            con.Close();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

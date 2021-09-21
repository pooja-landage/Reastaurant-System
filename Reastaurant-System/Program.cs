using System;
using System.Threading.Tasks;
using RestaurantLogic;

namespace Reastaurant_System
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter User Name");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();
            Restaurant.Validation(username, pass);
          
        }
    }
}

using System;

namespace CSharp
{
    public class Program
    {
        public static void Main()
        {
            var customers =new Customer[3];

            customers[1] = new Customer { Name = "Ali", Gender = 2};
            customers[2] = new Customer { Name = "Omar", Gender = 1};
            customers[3] = new Customer { Name = "Hassan", Gender = 1};
            foreach (var customer in customers)
            {
                Console.WriteLine("Name: {0} Gender: {1}",customer.Name,customer.Gender);
            }
        }

        public static string GetGender(int genderNumber)
        {
            switch (genderNumber)
            {
                case 0: return "Unknown";
                case 1: return "Male";
                case 2: return "Female";
                default: return "Invalid data Detected";
            }
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
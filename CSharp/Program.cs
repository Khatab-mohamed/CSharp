using System;

namespace CSharp
{
    public class Program
    {
        public static void Main()
        {
            var customers =new Customer[3];

            customers[0] = new Customer { Name = "Ali", Gender = Gender.Female};
            customers[1] = new Customer { Name = "Omar", Gender = Gender.Male};
            customers[2] = new Customer { Name = "Hassan", Gender = Gender.Unknown};
            foreach (var customer in customers)
            {
                Console.WriteLine("Name: {0} Gender: {1}",customer.Name,customer.Gender );
            }
        }

    }

    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
    /// <summary>
    /// Enum is Strongly Typed Constants
    /// for set of integral Numbers, replacing them with Enums
    /// To make the code more---> Readable, Maintainable
    /// </summary>

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    
}
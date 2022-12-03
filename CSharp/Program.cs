using System;

namespace CSharp
{
    public class Program
    {
        public static void Main()
        {
            var c1 = new Customer {FirstName = "Ali", LastName = "Omar"};
            c1.Print();
        }
        
    }

    public partial class Customer
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
    }
}
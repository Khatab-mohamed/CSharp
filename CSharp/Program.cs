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

    /// <summary>
    /// Partial Classes Allow Us to split classes into 2 or more Files
    /// </summary>
    public partial class Customer
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
    }
}
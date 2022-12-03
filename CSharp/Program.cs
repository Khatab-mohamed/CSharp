using System;

namespace CSharp
{
    public class Program
    {
        public static void Main()
        {
         var c = new Customer();
         c.NonPartial();
        }
        
    }

    /// <summary>
    /// Partial Classes Allow Us to split classes into 2 or more Files
    /// </summary>
    public partial class Customer
    {
        partial void PrintPartial();

        public void NonPartial()
        {
            Console.WriteLine("Non Partial Invokes");
            PrintPartial();

    }
}
}
using System;

namespace CSharp
{
    public class Program
    {
        public static void Main()
        {
            var c1= new Customer();
            var c2= new Customer();
            c1.FirstName = "Ali";
            c1.LastName = "Omar";
            c2.FirstName = "Ali";
            c2.LastName = "Omar";
            var equals = c1.Equals(c2);
            Console.WriteLine(equals);
            Console.WriteLine(c1 == c2);
        }
        
    }

    public class Customer
    {
        //  ToString Override
        public override string ToString()
        {
            return "I'm Overriding ToString Method";
        }
        //  Equals Override

        public override bool Equals(object obj)
        {
            if (!(obj is Customer))
                return false;

            return (FirstName == ((Customer) obj).FirstName && this.LastName == ((Customer) obj).LastName);
        }
        //  GetHashCode Override

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
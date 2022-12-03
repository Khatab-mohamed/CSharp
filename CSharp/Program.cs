using System;

namespace CSharp
{
    public class Program
    {
        public static void Main()
        {
            var equal = Calculator<int>.AreEqual(1, 2);


            //Using the Generic Class
            var equal1 = Calculator<int>.AreEqual(1, 2);
            var equal2 = Calculator<string>.AreEqual("VAL", "VAL");
            
            // Case the Class is not Generic & The Method is Generic
            //var equal3 = Calculator.AreEqual<double>(1.4,1.5);

            Console.WriteLine(equal ? "Equal" : "Not Equal");
            Console.WriteLine(equal1 ? "Equal" : "Not Equal");
            Console.WriteLine(equal2 ? "Equal" : "Not Equal");


        }
        
    }

    public class Calculator<T>
    {
        //  Generic Method using <T>
        public static bool AreEqual /*   <T> */( T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }
}
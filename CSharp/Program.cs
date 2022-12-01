using System;

namespace CSharp
{
    /// <summary>
    ///     Delegate is type safe function pointer
    ///     Reference Type;
    ///  
    /// </summary>
    public delegate void HelloFunctionDelegate(string message);


    public class Program
    {
        
        public static void Main()
        {
            var helloFunctionDelegate = new HelloFunctionDelegate(HelloMessage);
            // we passing in the Name of the Function which we want the Delegate point To.
            helloFunctionDelegate("Hi From Delegate"); 
        }
        public static void HelloMessage(string stringMessage)
        {
            Console.WriteLine(stringMessage);
        }
    }
}

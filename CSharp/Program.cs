using System;

namespace CSharp
{
    public class Program
    {
        public static void Main()
        {
            
            // 
            AddNumbers(1,2,1,2,3,4,5);
            //Second way to use optional parameters
            AddNumbers(1,2,new object[] {1,2,3,4,5});
        
        }
        //Optional Parameters using -->  params object[] 
        public static void AddNumbers(int firstName, int secondNumber, params object[] restNumbers)
        {
            var result = firstName + secondNumber;
            if (restNumbers!=null)
            {
                foreach (int number in restNumbers)
                {
                    result += number;
                }
                
                Console.WriteLine(result);
            }
        }
        
    }

}
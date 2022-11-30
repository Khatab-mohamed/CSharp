using System;

namespace CSharp
{
    /*Abstract Classes
    Cannot be Sealed
    */
    public abstract /*sealed*/ class Customer
    { 
        /* May Contain Abstract members
         Abstract member cannot have implementation 
        
         public abstract void printTest() { }
    */    
    public abstract void print();

    }
    //  If class does not wish to provide Implementation for all the abstract members inherited
    //  Then the class has to be marked as abstract
    public class /*Abstract*/ Program : Customer
    {
        /*
         An Non Abstract Class Derived from Abstract class Must provide Implementation for all abstract members .
         Using override KEYWORD
         */

        public override void print()
        {
            Console.WriteLine("Hello From Print Abstract Method");
        }

        public static void Main()
        {

        }
    }

 
}

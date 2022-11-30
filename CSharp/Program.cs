using System;

namespace CSharp
{
    // An interface cannot inherit from another interface only
    // Cannot inherit from Abstract Class

    interface ICustomer
    {
      //Interface cannot have fields
      // int Id = 101;
    }
    /// <summary>
    /// Can inherit from Abstract class an interface    
    /// </summary>
    public abstract class Customer
    { 
        /*
         Abstract Class's members can have access modifiers
         Public
         Protected
         Private
         internal
             */
        
    public abstract void AbstractPrint();

    //  Can have a Implementation for some of its members Methods
    public void Print()
    {
            Console.WriteLine("Hi Form Abstract Member");
    }
    //Can Have Fields 
    internal int Id;

    //Can have Constructors with parameter or less
    protected Customer(int id) { Id = id; }

    protected Customer(){ }

    }
    //  A class can inherit from multiple interfaces at the same time,
    //  Cannot inherit from multiple Abstract Classes at the same time
    public class Program : Customer
    {
        
        public override void AbstractPrint()
        {
            Console.WriteLine("Hello From Print Abstract Method");
        }

        public static void Main()
        {

        }
    }

 
}

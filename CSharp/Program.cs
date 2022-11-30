using System;

namespace CSharp
{
    public class A
    {
        public virtual void Print() { }
    }
    public class B:A
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }
    public class C:A
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }
    /*
             *  Class B & C are Inherited from class A and the are Overriding Print();
             *  Class D inherits from both of them B,C
             *  If D calls a method defined in class A
             *  And B and C have overridden that method ,
     * From which inherit: B or C ?
     * This ambiguity called                                DIAMOND PROBLEM
             */
    class D :B,C
    {
        public override void Print()
        {
          Console.WriteLine("C Implementation");
        }
    }
    public class Program
    { 
        public static void Main()
        {
            
            D d=new D();
            d.Print();

        }
    }
}

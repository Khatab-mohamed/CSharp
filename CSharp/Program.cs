using System;

namespace CSharp
{
    interface IA
    {
        void AMethod();
    }

    class A:IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }
    interface IB
    {
        void BMethod();
    }

    class B:IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }
    
    class C:IA,IB
    {
        A a =new A();
        B b = new B();

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }
    }


    public class Program
    { 
        public static void Main()
        {
            C c= new C();
            c.AMethod();
            c.BMethod();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp
{
    public  delegate void SampleDelegate();
    public class Program
    {
        public static void Main()
        {
            SampleDelegate del1, del2, del3,del4;
            del1= new SampleDelegate(SampleMethodOne);
            del2= new SampleDelegate(SampleMethodTow);
            del3= new SampleDelegate(SampleMethodThree);
            // Multi Cast Delegate:
            // is Delegate which is pointing to More than One Function
            //                          UnRegister Function using -=
            del4 = del1 + del2 + del3 - del2;
            del4();
            //Using += to Register this functions To Delegate
            SampleDelegate del5= new SampleDelegate(SampleMethodOne);
            del5 += SampleMethodTow;
            del5 += SampleMethodThree;
            del5 -= SampleMethodOne;
            Console.WriteLine("---------------------");

            del5();
        }

        public static void SampleMethodOne()
        {
            Console.WriteLine("Sample Method One");
        }
        public static void SampleMethodTow()
        {
            Console.WriteLine("Sample Method Two");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample Method Three");
        }

    }

}

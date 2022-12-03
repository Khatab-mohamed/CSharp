using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public partial class Customer
    {

        partial void PrintPartial()
        {
            Console.WriteLine("Partial Invokes");
        }

    }
}

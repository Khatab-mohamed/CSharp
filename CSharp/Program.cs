using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    /// <summary>
    ///     Dictionary
    ///     1- Dictionary is (key,value) Pairs
    ///     2- It's present in System.Collections.Generic;
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            var customer1 = new Customer {Id = 110, Name = "Mark", Salary = 3000};
            var customer2 = new Customer {Id = 115, Name = "Marry", Salary = 5000};
            var customer3 = new Customer {Id = 119, Name = "John", Salary = 9000};

            // 3- When Creating a dictionary, we need to specify the type of Key and Value.
            // 4- Keys must be unique
            var customersDictionary = new Dictionary<int, Customer>
            {
                {customer1.Id, customer1}, {customer2.Id, customer2}, {customer3.Id, customer3}
            };
            //  1-TryGetValue(key, out Value)
            if (customersDictionary.TryGetValue(110, out var customerCasting))
                Console.WriteLine("ID :{0}, Name:{1}, Salary:{2}", customerCasting.Id, customerCasting.Name,
                    customerCasting.Salary);
            else
                Console.WriteLine("The Key is not found");
            //  2- Count 
            Console.WriteLine("Total Items = {0}", customersDictionary.Count);
            //  3- Count()----> LINQ count Enumerable
            Console.WriteLine("Salary More than 4000  = {0}", customersDictionary.Count(kvp =>kvp.Value.Salary > 4000));
            //  4- Remove single value using the key
            customersDictionary.Remove(key:110);
            //  5- Clear --> Removing all items in the Dictionary
            customersDictionary.Clear();

            // 6- convert an array into Dictionary

            var customers = new Customer[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;
            var dictionary = customers.ToDictionary(c => c.Id, c => c);
        }
    }


    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
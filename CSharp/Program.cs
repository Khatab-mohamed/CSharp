using System;
using System.Collections.Generic;

namespace CSharp
{
    /// <summary>
    ///         Dictionary
    /// 1- Dictionary is (key,value) Pairs
    /// 2- It's present in System.Collections.Generic;
    /// 

    /// </summary>
    public class Program
    {
        public static void Main()
        {
            var customer1= new Customer(){Id = 110,Name = "Mark", Salary = 3000};
            var customer2= new Customer(){Id = 115,Name = "Marry", Salary = 5000};
            var customer3= new Customer(){Id = 119,Name = "John", Salary = 9000};

            // 3- When Creating a dictionary, we need to specify the type of Key and Value.
            // 4- Keys must be unique
            var customersDictionary = new Dictionary<int, Customer>
            {
                {customer1.Id, customer1}, {customer2.Id, customer2}, {customer3.Id, customer3}
            };

            var customer119 = customersDictionary[119];
            Console.WriteLine("\n ID :{0} \n Name : {1} \n Salary: {2} \n",customer119.Id,customer119.Name,customer119.Salary);
            
            // Using KeyValuePairs   
            foreach (KeyValuePair<int,Customer> valuePairCustomer in customersDictionary)
            {
                Console.WriteLine("\n ID :{0}", valuePairCustomer.Key);

                var customer = valuePairCustomer.Value;
                Console.WriteLine("\n Name :{0}  Salary : {1} ", customer.Name,customer.Salary);
                Console.WriteLine("------------------------------------------");
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }

}
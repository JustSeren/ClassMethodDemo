

using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Seren";
            customer1.Surname = "Kaya";
            customer1.Id = 1;
            customer1.CardInformation = "Student Card";

            Customer customer2 = new Customer();
            customer2.Name = "Dilay";
            customer2.Surname = "Ateş";
            customer2.Id = 2;
            customer2.CardInformation = "Student Card";

            Customer customer3 = new Customer();
            customer3.Name = "Mehmet";
            customer3.Surname = "Kılıç";
            customer3.Id = 3;
            customer3.CardInformation = "Retirement Card";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };


            foreach (Customer customer in customers)
            {
                Console.WriteLine("--------Customer-------");
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.CardInformation);
                Console.WriteLine();
            }
            Console.WriteLine();
            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerDelet(customer2);
            customerManager.CustomerReId(customer3);

        }
    }
}
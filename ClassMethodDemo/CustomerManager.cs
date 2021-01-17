using System;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {

            Console.WriteLine("Customer " + customer.Name + " " + customer.Surname + " added to system.");
        }

        public void CustomerDelet(Customer customer)
        {
            Console.WriteLine("Customer " + customer.Name + " " + customer.Surname + " deleted to system.");

        }

        public void CustomerReId(Customer customer)
        {
            Console.WriteLine("Customer " + customer.Name + " " + customer.Surname + "'s id has been reorganized.");
        }

    }
}












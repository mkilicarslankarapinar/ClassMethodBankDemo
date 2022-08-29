using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodBankDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer has been added!");
            Console.WriteLine(customer.FirstName + " " + customer.SecondName);
            Console.WriteLine("-----------------------");
            customers.Add(customer);
        }
        public void List()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.SecondName);
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.SecondName + " customer has been deleted!");
            customers.Remove(customer);
        }
    }
}

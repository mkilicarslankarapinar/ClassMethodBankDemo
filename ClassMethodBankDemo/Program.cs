using System;

namespace ClassMethodBankDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Kilicarslan";
            customer1.SecondName = "Karapinar";

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.FirstName = "Buse";
            customer2.SecondName = "Gültekin";

            Customer customer3 = new Customer();
            customer3.Id = 2;
            customer3.FirstName = "Nurdan";
            customer3.SecondName = "Barlas";



            CustomerManager manager = new CustomerManager();

            manager.Add(customer1);
            manager.Add(customer2);
            manager.Add(customer3);

            manager.List();
            Console.WriteLine("-----------------------");
            manager.Delete(customer2);
            Console.WriteLine("-----------------------");
            manager.List();
        }
    }
}

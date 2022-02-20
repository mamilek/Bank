using System;
using System.Collections.Generic;

namespace Bank.Helpers
{
    public class CustomersMenu
    {
        public List<Customer> GetListOfCustomers()
        {
            List<Customer> Customers = new List<Customer>();

            Customer Jan = new Customer();
            Jan.ID = 1;
            Jan.ImieInazwisko = "Jan Nowak";
            Jan.Konto = "001";
            Jan.Saldo = 1457.23m;

            Customer Agnieszka = new Customer();
            Agnieszka.ID = 2;
            Agnieszka.ImieInazwisko = "Agnieszka Kowalska";
            Agnieszka.Konto = "002";
            Agnieszka.Saldo = 3458.04m;

            Customer Robert = new Customer();
            Robert.ID = 3;
            Robert.ImieInazwisko = "Robert Lewandowski";
            Robert.Konto = "003";
            Robert.Saldo = 17544.22m;

            Customer Zofia = new Customer();
            Zofia.ID = 4;
            Zofia.ImieInazwisko = "Zofia Plucińska";
            Zofia.Konto = "004";
            Zofia.Saldo = 13500.54m;

            Customer Grzegorz = new Customer();
            Grzegorz.ID = 5;
            Grzegorz.ImieInazwisko = "Grzegorz Braun";
            Grzegorz.Konto = "005";
            Grzegorz.Saldo = 300.87m;


            Customers.Add(Jan);
            Customers.Add(Agnieszka);
            Customers.Add(Robert);
            Customers.Add(Zofia);
            Customers.Add(Grzegorz);
            return Customers;
        }

        public void DisplayCustomers(List<Customer> customers)
        {
            Console.WriteLine("ID | IMIĘ I NAZWISKO | NR KONTA | SALDO");

            foreach (var item in customers)
            {
                Console.WriteLine($"{item.ID.ToString()} | {item.ImieInazwisko} | {item.Konto.ToString()} | {item.Saldo.ToString()}");
            }
            Menu.DisplayMenu();
        }
    }
}

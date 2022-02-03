using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank.Helpers
{
    public class Login
    {
        public void LoginMenu()
        {
            Console.Clear();
            Console.WriteLine("ZALOGUJ SIĘ WYBIERAJĄC ID KLIENTA");

            var searchedCustomer = Console.ReadLine();

            List<Customer> customers = new List<Customer>();
            CustomersMenu customersMenu = new CustomersMenu();
            customers = customersMenu.GetListOfCustomers();

            Customer loggedCustomer = customers.Where(t => t.ID.ToString() == searchedCustomer).FirstOrDefault();

            if (loggedCustomer != null)
            {
                Console.Clear();
                Console.WriteLine("ZALOGOWANY KLIENT");
                Console.WriteLine("ID: "+loggedCustomer.ID);
                Console.WriteLine("IMIĘ I NAZWISKO: "+loggedCustomer.ImieInazwisko);
                Console.WriteLine("NUMER KONTA: "+loggedCustomer.Konto);
                Console.WriteLine("SALDO: "+loggedCustomer.Saldo);
                Console.WriteLine("WPISZ NUMER KONTA DO PRZELEWU:");

                var numerKonta = Console.ReadLine();

                Customer receiver = customers.Where(t => t.Konto == numerKonta).FirstOrDefault();
                if (receiver != null)
                {
                    if (receiver.Konto == loggedCustomer.Konto)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NIE MOŻESZ WYKONAĆ PRZELEWU NA SWÓJ RACHUNEK");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("PODAJ KWOTĘ:");
                        var response = Console.ReadLine();
                        
                        
                        try
                        {
                            var kwota = Convert.ToDecimal(response);
                            if (kwota <= loggedCustomer.Saldo)
                            {
                                loggedCustomer.Saldo = loggedCustomer.Saldo - kwota;
                                receiver.Saldo = receiver.Saldo + kwota;

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("PRZELEW WYKONANY");
                                Console.ForegroundColor = ConsoleColor.White;
                                customersMenu.DisplayCustomers();
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("NIE MASZ WYSTARCZAJĄCYCH ŚRODKÓW");
                            }
                        }
                        catch
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("NIE PODAŁEŚ LICZBY");
                        }
                    }
                }

                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ZŁY NUMER KONTA");
                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NIEUDANE LOGOWANIE");
            }
        }

        private void Transfer()
        {

        }
    }
}

using System;
namespace Bank.Helpers
{
    public static class Menu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("WYBIERZ OPCJĘ");
            Console.WriteLine("1 => LISTA WSZYSTKICH KLIENTÓW BANKU");
            Console.WriteLine("2 => LOGOWANIE");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3");

            var response = Console.ReadLine();

            if (response == "1")
            {
                CustomersMenu customersMenu = new CustomersMenu();
                customersMenu.DisplayCustomers();
            }
            else if (response == "2")
            {
                Login login = new Login();
                login.LoginMenu();
            }
            else if (response == "3")
            {
                //EndProgram();
            }
            else
            {
                Console.WriteLine("Wybierz poprawną opcję.");
            }
        }
    }
}

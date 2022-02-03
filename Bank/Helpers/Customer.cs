using System;
namespace Bank.Helpers
{
    public class Customer
    {
        public int ID { get; set; }
        public string ImieInazwisko { get; set; }
        public string Konto { get; set; }
        public decimal Saldo { get; set; }
    }
}
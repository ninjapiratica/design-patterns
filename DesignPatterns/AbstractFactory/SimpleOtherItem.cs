using System;

namespace DesignPatterns.AbstractFactory
{
    public class SimpleOtherItem : IOtherItem
    {
        public decimal Value { get; set; }

        public string Purpose => "Does Simple Things";

        public bool Sell(int quantity)
        {
            Console.WriteLine("Simple things don't sell.");
            return false;
        }
    }
}

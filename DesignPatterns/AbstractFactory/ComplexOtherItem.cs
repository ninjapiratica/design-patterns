using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class ComplexOtherItem : IOtherItem
    {
        public decimal Value { get; set; }

        public string Purpose => "Does Other Complex Things";

        public bool Sell(int quantity)
        {
            Console.WriteLine($"Complex Item sold {quantity} for {Value} each totaling {quantity * Value}.");
            return true;
        }
    }
}

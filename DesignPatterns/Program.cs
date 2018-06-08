using DesignPatterns.AbstractFactory;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                NewExample(FactoryExample, i);
                NewExample(BuilderExample, i);
            }
        }

        static void NewExample(Action<int> example, int exampleNumber)
        {
            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine($"Example {exampleNumber}");
            example(exampleNumber);
        }

        static void FactoryExample(int exampleNumber)
        {
            Console.WriteLine("Factory Example");

            IFactory factory;
            if (exampleNumber % 2 == 0)
                factory = new SimpleFactory();
            else
                factory = new ComplexFactory();

            var item = factory.GetItem();
            item.DoStuff();

            var otherItem = factory.GetOtherItem();
            otherItem.Sell(10);
        }

        static void BuilderExample(int exampleNumber)
        {

        }
    }
}

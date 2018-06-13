using DesignPatterns.AbstractFactory;
using System;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                NewExample(AbstractFactoryExample, i);
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

        static void AbstractFactoryExample(int exampleNumber)
        {
            Console.WriteLine("Abstract Factory Example");

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
            Console.WriteLine("Builder Example");

            var builder = new Builder.Builder();

            var item = builder.SetFirst(exampleNumber + 5)
                .SetSecond("a")
                .SetThird(new { Name = "John", Age = 10 * (exampleNumber + 1) })
                .CreateItem();

            Console.WriteLine(item);
        }
    }
}

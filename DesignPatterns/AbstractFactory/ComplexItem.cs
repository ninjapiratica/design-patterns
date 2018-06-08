using System;

namespace DesignPatterns.AbstractFactory
{
    public class ComplexItem : IItem
    {
        public int Id => 0;

        public string Name => "Item";

        public void DoStuff(params object[] objects)
        {
            Console.WriteLine($"Doing Complex Stuff with: {string.Join(", ", objects)}");
        }
    }
}

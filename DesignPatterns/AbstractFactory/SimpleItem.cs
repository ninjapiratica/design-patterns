using System;

namespace DesignPatterns.AbstractFactory
{
    public class SimpleItem : IItem
    {
        public int Id { get; set; }

        public string Name => "I AM A SIMPLE ITEM";

        public void DoStuff(params object[] objects)
        {
            Console.WriteLine("I Do Things");
        }
    }
}

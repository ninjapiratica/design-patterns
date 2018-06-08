namespace DesignPatterns.AbstractFactory
{
    public class SimpleFactory : IFactory
    {
        public IItem GetItem()
        {
            return new SimpleItem();
        }

        public IOtherItem GetOtherItem()
        {
            return new SimpleOtherItem();
        }
    }
}

namespace DesignPatterns.AbstractFactory
{
    public class ComplexFactory : IFactory
    {
        public IItem GetItem()
        {
            return new ComplexItem();
        }

        public IOtherItem GetOtherItem()
        {
            return new ComplexOtherItem();
        }
    }
}

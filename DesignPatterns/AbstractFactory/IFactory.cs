namespace DesignPatterns.AbstractFactory
{
    public interface IFactory
    {
        IItem GetItem();
        IOtherItem GetOtherItem();
    }
}

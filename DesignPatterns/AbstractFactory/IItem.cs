namespace DesignPatterns.AbstractFactory
{
    public interface IItem
    {
        int Id { get; }
        string Name { get; }

        void DoStuff(params object[] objects);
    }
}
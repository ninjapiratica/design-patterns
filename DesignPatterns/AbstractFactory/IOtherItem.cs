namespace DesignPatterns.AbstractFactory
{
    public interface IOtherItem
    {
        decimal Value { get; set; }
        string Purpose { get; }

        bool Sell(int quantity);
    }
}
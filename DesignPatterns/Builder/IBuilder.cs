namespace DesignPatterns.Builder
{
    public interface IBuilder
    {
        IBuilder SetFirst(int num);
        IBuilder SetSecond(string str);
        IBuilder SetThird(object obj);
        Item CreateItem();
    }
}

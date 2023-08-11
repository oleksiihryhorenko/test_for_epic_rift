namespace Core
{
    public interface ISpendable
    {
        bool IsEnough { get; }

        void Spend();
    }
}
using System;

namespace Model.Gold
{
    public class GoldManager
    {
        public static readonly GoldManager Instance = new();

        public delegate void GoldChangedDelegate(int newHealth, int changed);

        public event GoldChangedDelegate OnGoldChanged;
        public int Gold { get; private set; } = 1000;

        public void GoldChanged(int value)
        {
            Gold += value;
            OnGoldChanged?.Invoke(Gold, value);
        }
    }
}
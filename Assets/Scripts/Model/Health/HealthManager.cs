using System;

namespace Health
{
    public class HealthManager
    {
        public static readonly HealthManager Instance = new();
        public delegate void HealthChangedDelegate(int newHealth, int changed);

        public event HealthChangedDelegate OnHealthChanged;
        public int Health { get; private set; } = 1000;

        public void HealthChanged(int value)
        {
            Health += value;
            OnHealthChanged?.Invoke(Health, value);
        }
    }
}
using System;

namespace Ratings
{
    public class RatingsManager
    {
        public static readonly RatingsManager Instance = new();
        public delegate void RatingsChangedDelegate(int newHealth, int changed);

        public event RatingsChangedDelegate OnRatingsChanged;
        public int Ratings { get; private set; } = 1000;

        public void RatingsChanged(int value)
        {
            Ratings += value;
            OnRatingsChanged?.Invoke(Ratings, value);
        }
    }
}
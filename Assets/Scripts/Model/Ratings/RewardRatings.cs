using System;
using Core;
using UnityEngine;

namespace Ratings
{
    [Serializable]
    public class RewardRatings : IReward
    {
        [SerializeField] private int count;
        public void Take()
        {
            RatingsManager.Instance.RatingsChanged(count);
        }
    }
}
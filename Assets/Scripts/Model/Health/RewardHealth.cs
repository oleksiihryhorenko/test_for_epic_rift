using System;
using Core;
using UnityEngine;

namespace Health
{
    [Serializable]
    public class RewardHealth : IReward
    {
        [SerializeField] private int count;

        public void Take()
        {
            HealthManager.Instance.HealthChanged(count);
        }
    }
}
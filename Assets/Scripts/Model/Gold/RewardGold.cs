using System;
using Core;
using UnityEngine;

namespace Model.Gold
{
    [Serializable]
    public class RewardGold : IReward
    {
        [SerializeField] private int count;
        public void Take()
        {
            GoldManager.Instance.GoldChanged(count);
        }
    }
}
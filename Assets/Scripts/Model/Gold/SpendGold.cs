using System;
using Core;
using UnityEngine;

namespace Model.Gold
{
    [Serializable]
    public class SpendGold : ISpendable
    {
        [SerializeField] private int count;
        public bool IsEnough => GoldManager.Instance.Gold >= count;
        public void Spend()
        {
            GoldManager.Instance.GoldChanged(-count);
        }
    }
}
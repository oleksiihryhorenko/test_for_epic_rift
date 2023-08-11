using System;
using Core;
using UnityEngine;

namespace Health
{
    [Serializable]
    public class SpendHealth : ISpendable
    {
        [SerializeField] private int count;

        public bool IsEnough => HealthManager.Instance.Health >= count;
        public void Spend()
        {
            HealthManager.Instance.HealthChanged(-count);
        }
    }
}
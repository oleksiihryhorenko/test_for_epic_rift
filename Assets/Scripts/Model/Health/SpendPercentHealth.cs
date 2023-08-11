using System;
using Core;
using UnityEngine;

namespace Health
{
    [Serializable]
    public class SpendPercentHealth : ISpendable
    {
        [SerializeField] private float _percents; 
        public bool IsEnough => HealthManager.Instance.Health > 0;
        public void Spend()
        {
            var value = Mathf.CeilToInt(HealthManager.Instance.Health * _percents / 100);
            HealthManager.Instance.HealthChanged(-value);
        }
    }
}
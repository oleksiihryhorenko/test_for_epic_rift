using System;
using Core;
using Health;
using UnityEngine;

[Serializable]
public class RewardPercentHealth : IReward
{
    [SerializeField] private float _percents;
    public void Take()
    {
        var value = Mathf.CeilToInt(HealthManager.Instance.Health * _percents / 100);
        HealthManager.Instance.HealthChanged(value);
    }
}

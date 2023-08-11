using System;
using Core;
using UnityEngine;

namespace Ratings
{
    [Serializable]
    public class SpendRatings : ISpendable
    {
        [SerializeField] private int count;
        public bool IsEnough => RatingsManager.Instance.Ratings >= count;
        public void Spend()
        {
            RatingsManager.Instance.RatingsChanged(-count);
        }
    }
}
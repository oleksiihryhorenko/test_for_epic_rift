using System;
using Health;
using Ratings;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace UI.ResourcesPanel
{
    public class RatingsView : MonoBehaviour
    {
        [SerializeField] private TMP_Text ratingsText;
        private void Awake()
        {
            SetRatings(RatingsManager.Instance.Ratings);
            RatingsManager.Instance.OnRatingsChanged += OnRatingsChanged;
        }

        private void OnDestroy()
        {
            RatingsManager.Instance.OnRatingsChanged -= OnRatingsChanged;
        }

        private void OnRatingsChanged(int value, int changed)
        {
            SetRatings(value);
        }

        private void SetRatings(int value)
        {
            ratingsText.text = value.ToString();
        }
        
    }
}
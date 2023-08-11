using System;
using Health;
using TMPro;
using UnityEngine;

namespace UI.ResourcesPanel
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private TMP_Text healthText;
        private void Awake()
        {
            SetHealth(HealthManager.Instance.Health);
            HealthManager.Instance.OnHealthChanged += OnHealthChanged;
        }

        private void OnDestroy()
        {
            HealthManager.Instance.OnHealthChanged -= OnHealthChanged;
        }

        private void OnHealthChanged(int value, int changed)
        {
            SetHealth(value);
        }

        private void SetHealth(int value)
        {
            healthText.text = value.ToString();
        }
        
    }
}
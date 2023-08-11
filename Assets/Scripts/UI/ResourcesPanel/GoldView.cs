using System;
using Health;
using Model.Gold;
using TMPro;
using UnityEngine;

namespace UI.ResourcesPanel
{
    public class GoldView : MonoBehaviour
    {
        [SerializeField] private TMP_Text goldText;
        private void Awake()
        {
            SetGold(GoldManager.Instance.Gold);
            GoldManager.Instance.OnGoldChanged += OnGoldChanged;
        }

        private void OnDestroy()
        {
            GoldManager.Instance.OnGoldChanged -= OnGoldChanged;
        }

        private void OnGoldChanged(int value, int changed)
        {
            SetGold(value);
        }

        private void SetGold(int value)
        {
            goldText.text = value.ToString();
        }
        
    }
}
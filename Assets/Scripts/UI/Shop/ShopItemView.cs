using System;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ShopItemView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _title;
        [SerializeField] private Button _button;
        [SerializeField] private Image _buttonImage;
        [SerializeField] private ShopItemConfig _config;

        public void Init(ShopItemConfig config)
        {
            _config = config;
            _title.text = _config.Title;
            _button.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            _config.Spendables.ForEach(s => s.Spend());
            _config.Rewards.ForEach(r => r.Take());
        }
        
        private void Update()
        {
            var isEnable = _config.Spendables.All(s => s.IsEnough);
            _button.interactable = isEnable;
            _buttonImage.color = isEnable ? Color.green : Color.gray;
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnClick);
        }
    }
}
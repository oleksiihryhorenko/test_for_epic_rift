using Config;
using UnityEngine;

namespace UI
{
    public class ShopMenuView : MonoBehaviour
    {
        [SerializeField] private ShopConfig _shopConfig;
        [SerializeField] private ShopItemView _shopItemView;
        [SerializeField] private Transform _itemsContainer;
        
        private void Awake()
        {
            foreach (var shopItemConfig in _shopConfig.ShopItemConfigs)
            {
                var itemView = Instantiate(_shopItemView, _itemsContainer);
                itemView.Init(shopItemConfig);
            }

        }
    }
}
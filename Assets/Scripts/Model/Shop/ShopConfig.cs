using System.Collections.Generic;
using UnityEngine;

namespace Config
{
    [CreateAssetMenu]
    public class ShopConfig : ScriptableObject
    {
        public List<ShopItemConfig> ShopItemConfigs;
    }
}

using System.Collections.Generic;
using Core;
using UnityEngine;

[CreateAssetMenu]
public class ShopItemConfig : ScriptableObject
{
    public string Title;
    
    [SerializeReference, SelectImplementation(typeof(ISpendable))]
    public List<ISpendable> Spendables;
    
    [SerializeReference, SelectImplementation(typeof(IReward))]
    public List<IReward> Rewards;
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/New Item")]
public class ScriptableObjects : ScriptableObject
{
    public enum ItemType
    {
        Weapon,
        Armor
    }

    public ItemType _itemType;
    public string _itemName;
    public int _itemPrice;
    public Sprite _itemSprite;
}

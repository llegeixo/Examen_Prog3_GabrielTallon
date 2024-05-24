using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager _instance;

    public ScriptableObjects[] _weapons;
    public Text[] _weaponsNames;
    public Text[] _weaponsPrices;
    public Image[] _weaponsSprites;
    public ScriptableObjects[] _armor;
    public Text[] _armorNames;
    public Text[] _armorPrices;
    public Image[] _armorSprites;


    void Awake()
    {
        _instance = this;
    }
    
    public void AddObjectWeapon(ScriptableObjects _item)
    {
        for (int i = 0; i < _weapons.Length; i++)
        {
            if(_weapons[i] == null)
            {
                _weapons[i] = _item;
                _weaponsNames[i].text = _item._itemName;
                _weaponsPrices[i].text = _item._itemPrice.ToString();
                _weaponsSprites[i].sprite = _item._itemSprite;

                return;
            }
        }
    }

    public void AddObjectArmor(ScriptableObjects _item)
    {
        for (int i = 0; i < _armor.Length; i++)
        {
            if(_armor[i] == null)
            {
                _armor[i] = _item;
                _armorNames[i].text = _item._itemName;
                _armorPrices[i].text = _item._itemPrice.ToString();
                _armorSprites[i].sprite = _item._itemSprite;

                return;
            }
        }
    }
}
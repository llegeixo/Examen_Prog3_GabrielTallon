using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public ScriptableObjects _item;

    SpriteRenderer _spriteRenderer;
    private int _weaponLayer;
    private int _armorLayer;

    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Start()
    {
        _spriteRenderer.sprite = _item._itemSprite;
        _weaponLayer = LayerMask.NameToLayer("Weapon");
        _armorLayer = LayerMask.NameToLayer("Armor");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.layer == _weaponLayer)
            {
                InventoryManager._instance.AddObjectWeapon(_item);
            }
            else if (gameObject.layer == _armorLayer)
            {
                InventoryManager._instance.AddObjectArmor(_item);
            }

            Destroy(this.gameObject);
        }
    }
}

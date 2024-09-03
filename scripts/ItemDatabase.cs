using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase instance;
    private void Awake()
    {
        instance = this;
    }

    [SerializeField] ItemDataEntity ItemDataEntity = default;

    public Item Spawn(Item.Type type)
    {
        for (int i=0; i<ItemDataEntity.items.Count; i++)
        {
            Item itemData = ItemDataEntity.items[i];
            if (itemData.type == type)
            {
                return new Item(itemData);
            }
        }
        return null;
    }

    public GameObject CreateZoomItem(Item.Type itemType)
    {
        for (int i = 0; i < ItemDataEntity.items.Count; i++)
        {
            Item itemData = ItemDataEntity.items[i];
            if (itemData.type == itemType)
            {
                return Instantiate(itemData.zoomPrehub);
            }
        }
        return null;
    }
}

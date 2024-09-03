using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots = default;

    public static ItemBox instance;

    Slot selectSlot;
    Slot showSlot;

    private void Awake()
    {
        instance = this;
    }
    public void SetItem(Item item)
    {
        for (int i=0; i<slots.Length; i++)
        {
            Slot slot = slots[i];
            if (slot.IsEmpty())
            {
                slot.Set(item);
                break;
            }
        }
    }

    public void OnSlotClick(int position)
    {
        for (int i=0; i<slots.Length; i++)
        {
            slots[i].HideBackPanel();
        }
        slots[position].OnSelect();

        selectSlot = slots[position];
    }

    public bool CheckSelectItem(Item.Type useItemType)
    {
        if (selectSlot == null)
        {
            
            return false;
        }

        Item selectItem = ItemBox.instance.GetSelectItem();
        if (selectItem == null)
        {
            
            return false;
        }

        if (selectSlot.GetItem().type == useItemType)
        {
            return true;
        }
        
       
        return false;
    }


    public bool CheckShowItem(Item.Type useItemType)
    {
        if (showSlot == null)
        {
            return false;
        }
        if (showSlot.GetItem().type == useItemType)
        {
            return true;
        }
        return false;
    }

    public void UseSelectItem()
    {
        selectSlot.RemoveItem();
        selectSlot = null;
    }

    public void UseShowItem()
    {
        showSlot.RemoveItem();
        showSlot = null;
    }

    public Item GetSelectItem()
    {
        if (selectSlot == null)
        {
            return null;
        }
        return selectSlot.GetItem();
    }

    public void SetShowSlot()
    {
        showSlot = selectSlot;
    }
}

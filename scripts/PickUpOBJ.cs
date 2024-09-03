using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpOBJ : MonoBehaviour
{
    public Item.Type type = default;
    public void OnClickOBJ()
    {
        Item item = ItemDatabase.instance.Spawn(type);
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}

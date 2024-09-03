using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetItem : MonoBehaviour
{
    [SerializeField] GameObject flower;

    public UnityEvent ClearEvent;
    public void OnClickOBJ()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.Flower))
        {
            ItemBox.instance.UseSelectItem();
            SetFlower();
            ClearEvent.Invoke();
        }
    }

    void SetFlower()
    {
        flower.SetActive(true);
    }
}

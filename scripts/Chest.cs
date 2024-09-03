using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] Animation anim = default;

    [SerializeField] GameObject treauer = default;
    public void Open()
    {

        if (ItemBox.instance.CheckSelectItem(Item.Type.SilverKey))
        {
            ItemBox.instance.UseSelectItem();
            anim.Play();
            treauer.SetActive(true);
        }
    }
}

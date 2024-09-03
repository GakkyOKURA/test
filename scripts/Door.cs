using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Animation anim = default;

    [SerializeField] GameObject clearPanel = default;

    public void Open()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.RealKey))
        {
            ItemBox.instance.UseSelectItem();
            anim.Play();
            clearPanel.SetActive(true);
        }
        else
        {
            MessagePanel.instance.ShowPanel("Œ®‚ª‚©‚©‚Á‚Ä‚¢‚é");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleParent : MonoBehaviour
{
    [SerializeField] GameObject parent;

    public void OnClick()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.GoldKey))
        {
            MessagePanel.instance.ShowPanel("鍵が開いた");
            ItemBox.instance.UseSelectItem();
            UseKey();
        }
        else if (ItemBox.instance.CheckSelectItem(Item.Type.CopperKey))
        {
            MessagePanel.instance.ShowPanel("この鍵は合わない");
        }
        else if (ItemBox.instance.CheckSelectItem(Item.Type.SilverKey))
        {
            MessagePanel.instance.ShowPanel("この鍵は合わない");
        }
        else
        {
            MessagePanel.instance.ShowPanel("鍵がかかっている");
        }
    }

    void UseKey()
    {
        parent.SetActive(false);
    }
}

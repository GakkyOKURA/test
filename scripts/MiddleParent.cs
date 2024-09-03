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
            MessagePanel.instance.ShowPanel("Œ®‚ªŠJ‚¢‚½");
            ItemBox.instance.UseSelectItem();
            UseKey();
        }
        else if (ItemBox.instance.CheckSelectItem(Item.Type.CopperKey))
        {
            MessagePanel.instance.ShowPanel("‚±‚ÌŒ®‚Í‡‚í‚È‚¢");
        }
        else if (ItemBox.instance.CheckSelectItem(Item.Type.SilverKey))
        {
            MessagePanel.instance.ShowPanel("‚±‚ÌŒ®‚Í‡‚í‚È‚¢");
        }
        else
        {
            MessagePanel.instance.ShowPanel("Œ®‚ª‚©‚©‚Á‚Ä‚¢‚é");
        }
    }

    void UseKey()
    {
        parent.SetActive(false);
    }
}

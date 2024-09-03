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
            MessagePanel.instance.ShowPanel("�����J����");
            ItemBox.instance.UseSelectItem();
            UseKey();
        }
        else if (ItemBox.instance.CheckSelectItem(Item.Type.CopperKey))
        {
            MessagePanel.instance.ShowPanel("���̌��͍���Ȃ�");
        }
        else if (ItemBox.instance.CheckSelectItem(Item.Type.SilverKey))
        {
            MessagePanel.instance.ShowPanel("���̌��͍���Ȃ�");
        }
        else
        {
            MessagePanel.instance.ShowPanel("�����������Ă���");
        }
    }

    void UseKey()
    {
        parent.SetActive(false);
    }
}

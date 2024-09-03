using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpParent : MonoBehaviour
{
    [SerializeField] GameObject parent;

  

    public void OnClick()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.DoorKnob))
        {
            ItemBox.instance.UseSelectItem();
            UseKey();
           
        }
        else
        {
            MessagePanel.instance.ShowPanel("�����͌�������Ȃ����Ȃ����J���Ȃ�");
        }
    }

    void UseKey()
    {
        MessagePanel.instance.ShowPanel("�^���X���牽����������");
        parent.SetActive(false);
    }

}

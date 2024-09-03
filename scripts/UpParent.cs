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
            MessagePanel.instance.ShowPanel("鍵穴は見当たらないがなぜか開かない");
        }
    }

    void UseKey()
    {
        MessagePanel.instance.ShowPanel("タンスから何か音がした");
        parent.SetActive(false);
    }

}

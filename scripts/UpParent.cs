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
            MessagePanel.instance.ShowPanel("Œ®ŒŠ‚ÍŒ©“–‚½‚ç‚È‚¢‚ª‚È‚º‚©ŠJ‚©‚È‚¢");
        }
    }

    void UseKey()
    {
        MessagePanel.instance.ShowPanel("ƒ^ƒ“ƒX‚©‚ç‰½‚©‰¹‚ª‚µ‚½");
        parent.SetActive(false);
    }

}

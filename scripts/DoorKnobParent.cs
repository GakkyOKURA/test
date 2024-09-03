using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnobParent : MonoBehaviour
{
    [SerializeField] GameObject parent;

    [SerializeField] GameObject Knob;

    public void OnClick()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.DoorKnob))
        {
            ItemBox.instance.UseSelectItem();
            UseDoorKnob();
            SetDoorKnob();
        }
        else
        {
            MessagePanel.instance.ShowPanel("�J���Ȃ��B�����������Ă���A�h�A�m�u�������悤��");
        }

        if (ItemBox.instance.CheckSelectItem(Item.Type.RealKey))
        {
            MessagePanel.instance.ShowPanel("�悸�̓h�A�m�u���K�v��");
        }
    }

    void UseDoorKnob()
    {
        parent.SetActive(false);
    }

    void SetDoorKnob()
    {
        Knob.SetActive(true);
    }
}

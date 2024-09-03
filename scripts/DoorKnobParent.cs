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
            MessagePanel.instance.ShowPanel("開かない。鍵がかかっており、ドアノブも無いようだ");
        }

        if (ItemBox.instance.CheckSelectItem(Item.Type.RealKey))
        {
            MessagePanel.instance.ShowPanel("先ずはドアノブが必要だ");
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

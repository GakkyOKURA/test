using System;
using UnityEngine;

[Serializable]

public class Item
{
    public enum Type
    {
        RedTile,
        BlueTile,
        YellowTile,
        GoldKey,
        SilverKey,
        CopperKey,
        RealKey,
        Flower,
        DoorKnob,
        BrokenKeyUp,
        BrokenKeyDown,
    }
    public Type type;

    public Sprite sprite;

    public GameObject zoomPrehub;

    public Item(Item item)
    {
        this.type = item.type;
        this.sprite = item.sprite;
    }
}

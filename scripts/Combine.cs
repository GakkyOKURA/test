using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine : MonoBehaviour
{
    public void OnClickOBJ()
    {
        Debug.Log("you touched it:"+name);

        if ((ItemBox.instance.CheckShowItem(Item.Type.BrokenKeyUp) && ItemBox.instance.CheckSelectItem(Item.Type.BrokenKeyDown))
            || (ItemBox.instance.CheckShowItem(Item.Type.BrokenKeyDown) && ItemBox.instance.CheckSelectItem(Item.Type.BrokenKeyUp))
            )
        {
            ItemBox.instance.UseSelectItem();
            ItemBox.instance.UseShowItem();
            Item realKeyItem = ItemDatabase.instance.Spawn(Item.Type.RealKey);
            ItemBox.instance.SetItem(realKeyItem);

            ZoomPanel.instance.ShowItem(realKeyItem);
        }
    }
}


// 島津先生はItemBoxのinstance使いまくってるんだからItemBox内でやりゃあいいじゃん
// って言ってスクリプトを書き直してる。気になるなら３D脱出ゲーム125、アイテムの合成の38分あたりに飛んでみよう

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


// ���Ð搶��ItemBox��instance�g���܂����Ă�񂾂���ItemBox���ł��Ⴀ���������
// ���Č����ăX�N���v�g�����������Ă�B�C�ɂȂ�Ȃ�RD�E�o�Q�[��125�A�A�C�e���̍�����38��������ɔ��ł݂悤

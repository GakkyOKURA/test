using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassKit : MonoBehaviour
{
    // ‘S‘Ì‚ğŠÇ—‚·‚é‚à‚Ì
    // ³‰ğ‚Í410
    int[] correctAnswer = { 4, 1, 0 };

    [SerializeField] PasswordDial[] dialNumbers = default;

    public void OnClickButton()
    {
        if (CheckClear())
        {
            Kit.instance.KitOpen();
            Debug.Log("aiueo");
        }
    }

    bool CheckClear()
    {
        for (int i = 0; i < dialNumbers.Length; i++)
        {
            if (dialNumbers[i].number != correctAnswer[i])
            {
                return false;
            }
        }
        return true;
    }
}
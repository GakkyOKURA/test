using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordPanel : MonoBehaviour
{
    // ‘S‘Ì‚ğŠÇ—‚·‚é‚à‚Ì
    // ³‰ğ‚Í‚Q‚O‚U‚O
    int[] correctAnswer = { 2, 4, 5, 0 };

    [SerializeField] PasswordDial[] dialNumbers = default;

    public void OnClickButton()
    {
        if (CheckClear())
        {
            CameraManager.instance.OnBuckButton();
            LockerDoor.instance.LockerOpen();
            Debug.Log("aiueo");
        }
    }

    bool CheckClear()
    {
        for (int i=0; i<dialNumbers.Length; i++)
        {
            if (dialNumbers[i].number != correctAnswer[i])
            {
                return false;
            }
        }
        return true;
    }
}

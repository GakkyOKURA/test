using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PasswordDial : MonoBehaviour
{
    [SerializeField] TMP_Text numberText = default; // �\�����邽�߂̂���
    public int number = 0; //�@����
    // �N���b�N�����Ɛ����𑝂₷
    public void OnClick()
    {
        number++;
        if (number > 9)
        {
            number = 0;
        }
        numberText.text = number.ToString();

    }
}

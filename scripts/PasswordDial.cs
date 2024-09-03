using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PasswordDial : MonoBehaviour
{
    [SerializeField] TMP_Text numberText = default; // 表示するためのもの
    public int number = 0; //　数字
    // クリックされると数字を増やす
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

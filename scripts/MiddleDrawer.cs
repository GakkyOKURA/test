using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleDrawer : MonoBehaviour
{
    [SerializeField] Animator animator = default;
    bool IsOpen = false;

    public void OnClickOBJ()
    {
        if (IsOpen)
        {
            Close();
        }
        else
        {
            Open();
        }
    }

    void Open()
    {
        IsOpen = true;
        animator.Play("MiddleDrawerOpen");
    }

    void Close()
    {
        IsOpen = false;
        animator.Play("MiddleDrawerClose");
    }
}

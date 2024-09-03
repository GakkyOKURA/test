using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDoor : MonoBehaviour
{
    [SerializeField] Animation anime = default;

    public static LockerDoor instance;

    private void Awake()
    {
        instance = this;
    }
    public void LockerOpen()
    {
        anime.Play();
    }
}

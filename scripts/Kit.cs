using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kit : MonoBehaviour
{
    [SerializeField] Animation anime = default;
    [SerializeField] GameObject itemKey = default;

    public static Kit instance;

    private void Awake()
    {
        instance = this;
    }
    public void KitOpen()
    {
        itemKey.SetActive(true);
        anime.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCamera : MonoBehaviour
{
    [SerializeField] Camera specialCamera = default;

    private void Start()
    {
        specialCamera.gameObject.SetActive(false);
    }

    public void OnClick()
    {
        CameraManager.instance.ChengeCAmeraEX(specialCamera);
        specialCamera.gameObject.SetActive(true);
    }
}

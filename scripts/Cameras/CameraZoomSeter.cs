using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomSeter : MonoBehaviour
{
    [SerializeField] Camera subCamera = default;

    private void Start()
    {
        subCamera.gameObject.SetActive(false);
    }

    public void OnClick()
    {
        CameraManager.instance.ChangeCamera(subCamera);
        subCamera.gameObject.SetActive(true);
    }
}

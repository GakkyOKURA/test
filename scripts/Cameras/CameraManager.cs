using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject backPanel = default;
    [SerializeField] GameObject movePanels = default;

    public static CameraManager instance;
    private void Awake()
    {
        instance = this;
    }

    [SerializeField] Transform[] cameraPositions;
    int currentIndex = 0;

    private void Start()
    {
        currentIndex = 0;
        mainCamera = Camera.main;
        SetCameraPosition(currentIndex);
    }
    public void TurnRight()
    {
        currentIndex++;
        if (currentIndex >= cameraPositions.Length)
        {
            currentIndex = 0;
        }
        SetCameraPosition(currentIndex);
    }

    public void TurnLeft()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = cameraPositions.Length - 1;
        }
        SetCameraPosition(currentIndex);
    }
    void SetCameraPosition(int index)
    {
        mainCamera.transform.position = cameraPositions[index].position;
        mainCamera.transform.rotation = cameraPositions[index].rotation;
    }

    Camera subCamera;
    Camera mainCamera;
    Camera specialCamera;

    public void ChangeCamera(Camera subCamera)
    {
        this.subCamera = subCamera;
        backPanel.SetActive(true);
        mainCamera.gameObject.SetActive(false);
        ZoomPanel.instance.SetRenderCamera(subCamera);
        movePanels.SetActive(false);
    }

    public void ChengeCAmeraEX(Camera specialCamera) //zoomしてる状態からさらにzoomするためのコード
    {
        this.specialCamera = specialCamera;
        backPanel.SetActive(true);
        mainCamera.gameObject.SetActive(false);
        subCamera.gameObject.SetActive(false);
        ZoomPanel.instance.SetRenderCamera(specialCamera);
        movePanels.SetActive(false);
    }

    public void OnBuckButton() // back panelを押したときの動作
    {

        if (specialCamera == true)
        {
            backPanel.SetActive(false);
            this.specialCamera.gameObject.SetActive(false);
            this.subCamera.gameObject.SetActive(false); //なんか動いてるけどlogではhelloって出る、、、異常があればここ
            mainCamera.gameObject.SetActive(true);
            ZoomPanel.instance.SetRenderCamera(mainCamera);
            Debug.Log("hello");
            movePanels.SetActive(true);
        }
        else
        {
            backPanel.SetActive(false);
            this.subCamera.gameObject.SetActive(false);
            mainCamera.gameObject.SetActive(true);
            ZoomPanel.instance.SetRenderCamera(mainCamera);
            Debug.Log("good");
            movePanels.SetActive(true);
        }
    }

    public void OnBuckButtonEX()
    {
       // backPanel.SetActive(true);
       // this.specialCamera.gameObject.SetActive(false);
       // mainCamera.gameObject.SetActive(false);
       // ZoomPanel.instance.SetRenderCamera(subCamera);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPanel : MonoBehaviour
{
    [SerializeField] GameObject zoomPanel;
    Canvas canvas;
    [SerializeField] Transform zoomOBJParent;
    GameObject zoomItem;

    public static ZoomPanel instance;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        canvas = GetComponent<Canvas>();
        HideZoomPanel();
    }

    public void SetRenderCamera(Camera camera)
    {
        canvas.worldCamera = camera;
    }
    public void OnClickZoom()
    {
        Item selectItem = ItemBox.instance.GetSelectItem();
        if (selectItem == null)
        {
            return;
        }
        zoomPanel.SetActive(true);
        ShowClickItem();
    }

    void ShowClickItem()
    {
        if (zoomItem != null)
        {
            Destroy(zoomItem);
        }
        Item selectItem = ItemBox.instance.GetSelectItem();
        ShowItem(selectItem);
    }


    public void ShowItem(Item item)
    {
        if (zoomItem != null)
        {
            Destroy(zoomItem);
        }
        zoomItem = ItemDatabase.instance.CreateZoomItem(item.type);
        zoomItem.transform.SetParent(zoomOBJParent, false);
        ItemBox.instance.SetShowSlot();
    }

    public void HideZoomPanel()
    {
        zoomPanel.SetActive(false);
    }
}

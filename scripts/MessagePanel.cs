using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagePanel : MonoBehaviour
{
    [SerializeField] GameObject messagePanel = default;
    [SerializeField] Text messageText = default;

    public static MessagePanel instance;
    private void Awake()
    {
        instance = this;
    }
    public void ShowPanel(string message)
    {
        messagePanel.SetActive(true);
        messageText.text = message;
    }

    public void HidePanel()
    {
        messagePanel.SetActive(false);
    }
}

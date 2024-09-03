using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZTitle : MonoBehaviour
{
    [SerializeField] string nextSceneName = default;
    public void NextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}

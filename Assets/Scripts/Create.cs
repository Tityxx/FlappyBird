using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject gameCamera;
    public GameObject settingsCamera;
    public GameObject gameOverCamera;

    void Start()
    {
        gameCamera.SetActive(false);
        settingsCamera.SetActive(false);
        gameOverCamera.SetActive(false);
    }
}

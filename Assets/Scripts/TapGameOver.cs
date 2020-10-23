using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapGameOver : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject gameOverCamera;

    void OnMouseDown()
    {
        gameOverCamera.SetActive(false);
        mainCamera.SetActive(true);
    }
}

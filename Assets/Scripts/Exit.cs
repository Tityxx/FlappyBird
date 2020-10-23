using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject settCamera;
    public GameObject mainCamera;

    void OnMouseDown()
    {
        settCamera.SetActive(false);
        mainCamera.SetActive(true);
    }
}

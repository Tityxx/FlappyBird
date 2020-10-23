using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject settCamera;
    public GameObject mainCamera;

    void OnMouseDown()
    {
        mainCamera.SetActive(false);
        settCamera.SetActive(true);
        
    }
}

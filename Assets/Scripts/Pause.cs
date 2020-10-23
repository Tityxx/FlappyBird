using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject secCamera;
    public GameObject mainCamera;
    public GameObject bird;
    public GameObject mainBird;
    public GameObject window;
    public AudioClip vzhuh;
    private Transform trans;

    void Start()
    {
        trans = window.GetComponent<Transform>();
    }

    void OnMouseDown()
    {
        secCamera.SetActive(false);
        mainCamera.SetActive(true);
        StopAllCoroutines();
        Switch_(bird, mainBird, trans);
    }

    public static void Switch_(GameObject bird, GameObject mainBird, Transform trans)
    {
        bird.GetComponent<Animation>().Play("BirdAnimation");
        mainBird.GetComponent<Animation>().Play("BirdAnimation");
        MoveWindow.play = false;
        trans.position = new Vector3(10, trans.position.y, trans.position.z);
        DestroyAll("Block");
    }

    public static void DestroyAll(string tag)
    {
        GameObject[] blocks = GameObject.FindGameObjectsWithTag(tag);
        for (int i = 0; i < blocks.Length; i++)
        {
            Destroy(blocks[i]);
        }
    }
}

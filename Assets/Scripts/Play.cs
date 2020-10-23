using System.Collections;
using UnityEngine;

public class Play : MonoBehaviour
{
    public GameObject secCamera;
    public GameObject mainCamera;
    public GameObject bird;
    public GameObject mainBird;
    public GameObject window;
    public GameObject blocks;
    public Transform block1;
    public Transform block2;
    private Transform trans;

    private float distance = 10.5f;
    private float maxYb1 = 17.33f;
    private float minYb1 = 12.33f;
    private float currX;

    void Start()
    {
        trans = window.GetComponent<Transform>();
    }

    void OnMouseDown()
    {
        mainCamera.SetActive(false);
        secCamera.SetActive(true);
        mainBird.GetComponent<Animation>().Play("DoNothing");
        bird.GetComponent<Animation>().Play("Rotate2");
        MoveWindow.play = true;
        currX = trans.position.x;
        StartCoroutine(BuildLevel());
    }

    IEnumerator BuildLevel()
    {
        while (true)
        {
            if(currX < trans.position.x + 5)
            {
                int y1 = Random.Range((int)minYb1 + 1, (int)maxYb1 + 1);
                int y2 = y1 - (int)distance;
                currX += 6;
                Instantiate(block1, new Vector3(currX, y1, 0), Quaternion.identity, blocks.transform).tag = "Block";
                Instantiate(block2, new Vector3(currX, y2, 0), Quaternion.identity, blocks.transform).tag = "Block";
            }
            yield return new WaitForEndOfFrame();
        }
    }
}

using System;
using UnityEngine;
using UnityEngine.UI;

public class BirdCollider : MonoBehaviour
{
    public GameObject secCamera;
    public GameObject gameOverCamera;
    public GameObject bird;
    public GameObject mainBird;
    public GameObject window;
    public GameObject blocks;
    public Text counter;
    public Text endGameCounter;
    public Dropdown dropdown;
    private Transform trans;

    void Start()
    {
        trans = window.GetComponent<Transform>();
    }

    void Update()
    {
        if(blocks.transform.childCount != 0)
        {
            GameObject child1 = blocks.transform.GetChild(1).gameObject;
            if(window.transform.position.x > child1.transform.position.x + 3)
            {
                GameObject child0 = blocks.transform.GetChild(0).gameObject;
                child1.transform.parent = null;
                child0.transform.parent = null;
                counter.text = (Int32.Parse(counter.text) + 1).ToString();
            }
        }
        if (bird.transform.position.y < 4.7 || bird.transform.position.y > 15.2 || 
            (window.transform.position.x - bird.transform.position.x) > 3.1)
        {
            Switch_window();
        }
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if(dropdown.value == 1) Switch_window();
    }

    private void Switch_window()
    {
        secCamera.SetActive(false);
        gameOverCamera.SetActive(true);
        endGameCounter.text = counter.text;
        counter.text = "0";
        StopAllCoroutines();
        Pause.Switch_(bird, mainBird, trans);
    }
}

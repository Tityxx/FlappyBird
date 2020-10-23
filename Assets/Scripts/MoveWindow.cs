using UnityEngine;

public class MoveWindow : MonoBehaviour
{
    static public bool play = false;
    public GameObject window;
    private Transform trans;
    private float speed = 2f;

    void Start()
    {
        trans = window.GetComponent<Transform>();
    }

    void Update()
    {
        if (play)
        {
            trans.position = new Vector3(trans.position.x + speed * Time.deltaTime, trans.position.y, trans.position.z);
            speed += 0.05f * Time.deltaTime;
        }
        else speed = 2f;
    }

}

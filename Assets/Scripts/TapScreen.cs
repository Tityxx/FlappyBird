using UnityEngine;

public class TapScreen : MonoBehaviour
{
    public GameObject bird;
    public AudioClip vzhuh;
    private float jumpForce = 120f;
    
    void OnMouseDown()
    {
        GetComponent<AudioSource>().PlayOneShot(vzhuh);
        bird.GetComponent<Animation>().Play("Rotate1");
        bird.GetComponent<Rigidbody2D>().AddForce(transform.up * jumpForce, ForceMode2D.Force);
        bird.GetComponent<Animation>().Play("Rotate2");
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public ScoreKeeper scorekeeper;
    public float speed;

    private Rigidbody rb;
    private bool canJump;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);

        if(canJump)
        {
            canJump = false;
            rb.AddForce(0, 5, 0, ForceMode.Impulse);
        }
    }

    void Update ()
    {
        if(Input.GetButtonDown("Jump"))
        {
            canJump = true;
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ( "Pick Up"))
        {
            other.gameObject.SetActive (false);
            scorekeeper.IncreaseScore();
        }
    }
}
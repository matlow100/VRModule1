using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowTrigger : MonoBehaviour
{
    public Text countText;
    public Text winText;
    
    // private Rigidbody rb;
    private int count;
    
    void Start ()
    {
        // rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winText.text = "";
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("projectile"))
        {
            gameObject.SetActive(false); // make sure this is the Pick Up, not the arrow!!
            count = count + 1;
            SetCountText();
        }
    }
    
    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count >= 10)
        {
            winText.text = "You Win!";
        }
    }
}

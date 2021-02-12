using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowTrigger : MonoBehaviour
{
    public ScoreKeeper scorekeeper;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("projectile"))
        {
            gameObject.SetActive(false);
            scorekeeper.IncreaseScore();
        }
    }
}

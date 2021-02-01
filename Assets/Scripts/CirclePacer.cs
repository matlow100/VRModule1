using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CirclePacer : MonoBehaviour
{
    
    public float radius = 7.0f;
    private float currentAngle = 0.0f;

    // Update is called once per frame
    void Update()
    {
        float angleNew = currentAngle + Time.deltaTime;
        
        transform.position = new Vector3(calculateX(angleNew), 0.75f, calculateY(angleNew));
        currentAngle = angleNew;
    }

    float calculateX(double angle)
    {
        return radius * (float)Math.Sin(angle);
    }

    float calculateY(double angle)
    {
        return radius * (float)Math.Cos(angle);
    }
}

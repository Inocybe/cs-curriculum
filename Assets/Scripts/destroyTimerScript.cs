using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTimerScript : MonoBehaviour
{
    public float time;

    public void FixedUpdate()
    {
        time -= Time.deltaTime;
        
        if (time <= 0f)
            Destroy(gameObject);
    }
}

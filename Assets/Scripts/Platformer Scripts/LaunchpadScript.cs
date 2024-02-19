using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchpadScript : MonoBehaviour
{
    public float launch_strangth;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * launch_strangth, ForceMode2D.Impulse);
        }
    }
}

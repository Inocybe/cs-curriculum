using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnpointScript : MonoBehaviour
{
    public List<GameObject> spawnPoints = new List<GameObject>();
    
    private void Start()
    {
        foreach (Transform child in transform)
        {
            spawnPoints.Add(child.gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
        }
    }
}

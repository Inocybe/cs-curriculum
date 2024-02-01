using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject currentSpawn;

    public HudManager manager;

    public void Respawn()
    {
        transform.position = currentSpawn.transform.position;
    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spawnpoint"))
        {
            if (manager.spawnPoints.ContainsKey(other.transform))
            {
                manager.spawnPoints[other.transform] = true;
            }
            //other.transform.position
        }
    }
}

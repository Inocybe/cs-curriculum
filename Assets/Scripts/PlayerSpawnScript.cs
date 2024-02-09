using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawnScript : MonoBehaviour
{
    public HudManager manager;

    private void Start()
    {
        Debug.Log(manager.selectedSpawnIndex);
        //this gets from manager dict gets the key at the index that person selected index
        transform.position = manager.spawnPoints.ElementAt(manager.selectedSpawnIndex).Key.position;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spawnpoint"))
        { 
            manager.spawnPoints[other.transform] = true;
        }
    }

    public void Death()
    {
        SceneManager.LoadScene(3);
    }
}

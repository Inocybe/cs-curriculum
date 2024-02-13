using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawnScript : MonoBehaviour
{
    private HudManager manager;

    private void Start()
    {
        manager = FindObjectOfType<HudManager>();
        for (int i = 0, len = manager.spawnPoints.Count; i < len; i++)
        {
            print(manager.spawnPoints.ElementAt(i));
        }
        Debug.Log(manager.selectedSpawnIndex);
        Debug.Log(manager.spawnPoints.ElementAt(manager.selectedSpawnIndex));
        //this gets from manager dict gets the key at the index that person selected index
        transform.position = manager.spawnPoints.ElementAt(manager.selectedSpawnIndex).Key;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spawnpoint"))
        { 
            manager.spawnPoints[other.transform.position] = true;
        }
    }

    public void Death()
    {
        SceneManager.LoadScene(3);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawnScript : MonoBehaviour
{
    [SerializeField] public Transform currentSpawn;

    public HudManager manager;

    private void Start()
    {
        transform.position = currentSpawn.position;
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

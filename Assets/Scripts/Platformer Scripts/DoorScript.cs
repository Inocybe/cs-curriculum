using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using Unity.VisualScripting;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public float closingSpeed;

    [SerializeField] private GameObject door;
    [SerializeField] private GameObject player;

    private HudManager manager;

    private void Start()
    {
        manager = FindObjectOfType<HudManager>();
        
        if (manager.doorClosed && manager.spawnPoints.ElementAt(3).Value)
        {
            door.transform.position = new Vector3(0f, 1.5f, 0f);
        }
    }

    private void Update()
    {
        if (manager.doorClosed && player.transform.position.x < transform.position.x && door.transform.position.y >= transform.position.y + 1.5f)
        {
            door.transform.position -= new Vector3(0f, closingSpeed * Time.deltaTime, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            manager.doorClosed = true;
        }
    }
}

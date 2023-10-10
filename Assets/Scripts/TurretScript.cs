using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public Vector3 turretOriginPoint;
    private GameObject player;
    public GameObject projectile;
    public float shootTimer = 1f;
    
    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            //run timer code here
            shootTimer -= Time.deltaTime;
        }


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CreateBullet(other.transform.position);
            player = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player = null;
        }
    }

    private void CreateBullet(Vector3 position)
    {
        //Instantiate(projectile, turretOriginPoint);
    }
}

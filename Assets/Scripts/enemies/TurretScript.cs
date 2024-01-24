using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public GameObject shootPoint;
    private GameObject player;
    public GameObject projectile;
    public float originalShootTimer = 1f;
    private float shootTimer;
    private bool inRange = false;

    private void Start()
    {
        shootTimer = originalShootTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {
            shootTimer -= Time.deltaTime;
            if (shootTimer <= 0f)
            {
                CreateBullet();
                shootTimer = originalShootTimer;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CreateBullet();
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            inRange = false;
            shootTimer = originalShootTimer;

        }
    }

    private void CreateBullet()
    {
        Instantiate(projectile, shootPoint.transform);
    }   
}

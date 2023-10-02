using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;


public class PlayerScript : MonoBehaviour
{
    public int coins;
    public int health;
    public float hitTimer;
    private float originalHitTimer;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;

    void Start()
    {
        originalHitTimer = hitTimer;
    }
    
    void Update()
    {
        hitTimer -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Coin"))
        {
            coins++;
            other.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (CompareTag("Spikes"))
        {
            ChangeHealth(-2);
        }
    }

    private void ChangeHealth(int amount)
    {
        health += amount;
    }
}

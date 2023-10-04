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
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;

    void Update()
    {
        Timer();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coins++;
            coinText.text = "Coins: " + coins.ToString();
            other.gameObject.SetActive(false);
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            ChangeHealth(-2, 5);
        }
    }

    private void ChangeHealth(int amount, float time)
    {
        if (hitTimer <= 0)
            health += amount;
        hitTimer = time;
        healthText.text = "Health: " + health.ToString();
    }
    

    private void Timer()
    {
        hitTimer -= Time.deltaTime;
    }
}

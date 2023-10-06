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

    private bool _iFrames = false;
    private float _startTime;

    private void Update()
    {
        HealthUpdateTimer();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coins++;
            other.gameObject.SetActive(false);
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            ChangeHealth(-2, 0.5f);
        }
    }

    private void ChangeHealth(int amount, float time)
    {
        if (!_iFrames)
        {
            health += amount;
            _iFrames = true;
            _startTime = time;
        }
    }

    private void HealthUpdateTimer()
    {
        if (_iFrames)
        {
            _startTime -= Time.deltaTime;
            if (_startTime <= 0)
                _iFrames = false;
        }
    }
}

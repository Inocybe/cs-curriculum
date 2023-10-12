using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public PlayerHUD hud;
    
    private bool _iFrames = false;
    private float _startTime;

    private void Start()
    {
        hud = GameObject.FindObjectOfType<PlayerHUD>();
    }

    private void Update()
    {
        HealthUpdateTimer();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            hud.coins++;
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
            hud.health += amount;
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public PlayerHUD hud;

    private TopDown_AnimatorController _controller;
    private bool _iFrames = false;
    private float _startTime;
    private bool _hasAxe = false;
    
    //array of ints, stores which item is held, if at 0, not held, make sure only holding one item at a time
    //shovel, axe
    private int[] _currentItem = {1, 0};

    private void Start()
    {
        _controller = GetComponent<TopDown_AnimatorController>();
        hud = FindObjectOfType<PlayerHUD>();
    }

    private void Update()
    {
        HealthUpdateTimer();
        CurrentWeapon();
        WeaponAttack();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            hud.coins++;
            other.gameObject.SetActive(false);
        }

        if (other.CompareTag("Axe"))
        {
            _hasAxe = true;
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

    public void ChangeHealth(int amount, float time)
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

    private void WeaponAttack()
    {
        
    }

    private void CurrentWeapon()
    {
        //doesnt work
        /*
        if (Input.GetKeyDown(KeyCode.Alpha2) && _hasAxe)
        {
            _currentItem[0] = 0;
            _currentItem[1] = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _currentItem[0] = 1;
            _currentItem[1] = 0;
        }

        if (_currentItem[0] == 1)
            _controller.SwitchToShovel();
        else if (_currentItem[1] == 1)
            _controller.SwitchToAxe();*/
    }
}

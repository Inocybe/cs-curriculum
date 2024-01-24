using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeAtackRotation : MonoBehaviour
{
    //axe direction will change which way hit area if facinh
    // 0 up, 1 right, 2 down, 3 left
    [HideInInspector] public int axeDirection = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            /*switch (axeDirection)
            {
                case 0:
                    gameObject.transform.rotation 
            }*/
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
        }
    }
}

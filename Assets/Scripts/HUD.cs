using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    public static PlayerHUD hud;
    public int coins;
    public int health;
    
    public PlayerScript playerScript;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;

    private void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coins;
        healthText.text = "Health: " + health;
    }
}

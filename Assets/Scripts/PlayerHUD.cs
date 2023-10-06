using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    public PlayerScript playerScript;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + playerScript.coins;
        healthText.text = "Health: " + playerScript.health;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class HudManager : MonoBehaviour
{
    private static HudManager hud;
    public int coins;
    public int health;
    
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    
    private GameObject _spawnpointParent;
    public Dictionary<Transform, bool> spawnPoints = new Dictionary<Transform, bool>();
    private bool _spawnsLoaded;

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

    private void Start()
    { 
        _spawnpointParent = GameObject.Find("Spawn Points");
        if (_spawnpointParent != null && !_spawnsLoaded)
        {
            foreach (Transform child in transform)
            {
                spawnPoints.Add(child, false);
            }

            _spawnsLoaded = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + coins;
        healthText.text = "Health: " + health;
    }
}



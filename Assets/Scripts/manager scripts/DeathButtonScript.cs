using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class DeathButtonScript : MonoBehaviour
{ 
    public HudManager manager;
    public GameObject buttonPrefab;
    public GameObject buttonParent;

    private void Start()
    {
        for (int i = 0, len = manager.spawnPoints.Count; i < len; i++)
        {
            if (manager.spawnPoints.ElementAt(i).Value)
            {
                GameObject button = Instantiate(buttonPrefab, buttonParent.transform);
                button.transform.position += new Vector3(0f, -20 * i, 0f);
                //button.GetComponent<Button>().onClick.AddListener(() => SelectSpawnpoint(i));
            }
            Debug.Log("works");
        }
    }

    private void SelectSpawnpoint(int spawnpointIndex)
    {
        Debug.Log("Selected Spawnpoint " + spawnpointIndex);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnScriptableObject", menuName = "ScriptableObjects/Spawnpoints")]
public class SpawnpointHandler : ScriptableObject
{
    public List<GameObject> spawnPoints = new List<GameObject>();

    private void OnEnable()
    {
        spawnPoints.Add(GameObject.FindGameObjectWithTag("Spawnpoint"));
    }
}

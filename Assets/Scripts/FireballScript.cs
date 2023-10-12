using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    public GameObject player;
    public float destroyTimer;
    private Vector3 _moveTo;
    
    // Start is called before the first frame update
    void Start()
    {
        _moveTo = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

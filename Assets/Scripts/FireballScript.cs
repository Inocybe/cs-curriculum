using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    private GameObject player;
    private Vector3 moveTowards = Vector3.zero;
    public float speed;
    public float destroyTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        moveTowards = (player.transform.position - transform.position).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveTowards * Time.deltaTime;
        destroyTimer -= Time.deltaTime;
        if (destroyTimer <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<PlayerScript>();
            Destroy(gameObject);
        }
    }
}

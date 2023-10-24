using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    private PlayerScript playerScript;
    
    private GameObject player;
    private Vector2 moveTowards = Vector2.zero;
    public float speed;
    public float destroyTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerScript = player.GetComponent<PlayerScript>();
        moveTowards = (player.transform.position - transform.position).normalized * 1000f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveTowards, speed * Time.deltaTime);
        destroyTimer -= Time.deltaTime;
        if (destroyTimer <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerScript.ChangeHealth(-10, 0.5f);
            Destroy(gameObject);
        }
    }
}

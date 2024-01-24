using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    private PlayerScript playerScript;
    
    private GameObject player;
    private Rigidbody2D rb;
    
    public float speed;
    public float destroyTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        playerScript = player.GetComponent<PlayerScript>();
        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += direction * Time.deltaTime;
        destroyTimer -= Time.deltaTime;
        if (destroyTimer <= 0)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerScript.ChangeHealth(-10, 0.5f);
            Destroy(gameObject);
        }
    }
}

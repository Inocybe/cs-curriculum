using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D rb;
    
    public float destroyTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Vector2.MoveTowards(transform.position, player.position, 10f), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

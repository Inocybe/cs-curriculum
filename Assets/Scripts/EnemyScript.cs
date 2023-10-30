using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private GameObject player;
    
    private float distanceFromPlayer;
    public int agroDistance;
    public float walkingSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        distanceFromPlayer = Vector2.Distance(player.transform.position, transform.position);

        if (distanceFromPlayer < agroDistance)
        {
            //moves towards player if distance from player is less then agro distance
            //transform.position = Vector2.MoveTowards(transform.position, player.transform.position, walkingSpeed * Time.deltaTime); /* editing this to create pathfinding */
        }
    }
}

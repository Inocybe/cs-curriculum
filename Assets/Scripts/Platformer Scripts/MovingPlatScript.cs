using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatScript : MonoBehaviour
{
    public float moveSpeed;
    
    [SerializeField] public List<Transform> targets;
    public int transformTarget = 1;

    private bool _platformCycleUp;

    private void Update()
    {
        if (transform.position == targets[transformTarget].position)
        {
            
        }
    }
    
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, targets[transformTarget].position, moveSpeed * Time.deltaTime);
    }
}

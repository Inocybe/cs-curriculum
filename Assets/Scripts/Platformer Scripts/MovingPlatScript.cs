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
            transformTarget = (transformTarget >= targets.Count - 1) ? 0 : transformTarget + 1;
        }
    }
    
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, targets[transformTarget].position, moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);
        }
    }
}

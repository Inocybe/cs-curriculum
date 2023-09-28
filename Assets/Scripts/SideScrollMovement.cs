using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform transform;
    
    public float walkingSpeed;
    private float xDirection;
    public float jumpForce;
    
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        xDirection = Input.GetAxis("Horizontal");
        transform.position += new Vector3(xDirection * walkingSpeed * Time.deltaTime, 0, 0);
    }
    
    
    
}

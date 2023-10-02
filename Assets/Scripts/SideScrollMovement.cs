using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public new Transform transform;
    
    public float walkingSpeed;  
    public float jumpForce;
    
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * walkingSpeed * Time.deltaTime, 0, 0);
    }
    
    
    
}

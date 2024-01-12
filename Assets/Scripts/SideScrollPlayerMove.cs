using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SideScrollPlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb; 
    [SerializeField] Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    
    public float xWalkingSpeed;  
    public float yWalkingSpeed;
    public float jumpingPower;
    
    private float _originalYSpeed;
    private float _horizontal;
    
    // Start is called before the first frame update
    void Start()
    {
        _originalYSpeed = yWalkingSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.velocity = new Vector2(_horizontal * xWalkingSpeed, rb.velocity.y);
        //transform.position += new Vector3(Input.GetAxis("Horizontal") * xWalkingSpeed * Time.deltaTime, Input.GetAxis("Vertical") * yWalkingSpeed * Time.deltaTime,0f);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, .4f, groundLayer);
    }

    private void Jump()
    {
        
        
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && !IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * .5f);
        }
    }

}

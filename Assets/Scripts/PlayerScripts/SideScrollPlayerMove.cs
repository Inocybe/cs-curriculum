using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Color = System.Drawing.Color;

public class SideScrollPlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb; 
    [SerializeField] Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private SpriteRenderer playerSprite;
    
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
        CheckWall();
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
        if (Physics2D.Raycast(transform.position, Vector2.down, .7f, groundLayer))
            return true;
        if (Physics2D.Raycast(transform.position + new Vector3(0.35f, 0f, 0f), Vector2.down, .7f, groundLayer))
            return true;
        if (Physics2D.Raycast(transform.position + new Vector3(-0.35f, 0f, 0f), Vector2.down, .7f, groundLayer))
            return true;

        return false;
    }

    private bool ThreeWallRaycast()
    {
        Vector2 direction = playerSprite.flipX ? Vector2.right : Vector2.left;
        if (Physics2D.Raycast(transform.position, direction, .6f, groundLayer))
            return false;
        if (Physics2D.Raycast(transform.position + new Vector3(0f, -0.5f, 0f), direction, .6f, groundLayer))
            return false;
        if (Physics2D.Raycast(transform.position + new Vector3(0f, 0.5f, 0f), direction, .6f, groundLayer))
            return false;
        return true;
    }

    private void CheckWall()
    {
        if (!ThreeWallRaycast())
        {
            _horizontal = 0f;
        }
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

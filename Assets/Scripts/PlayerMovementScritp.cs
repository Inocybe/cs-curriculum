using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementScritp : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    
    public float xWalkingSpeed;  
    public float yWalkingSpeed;
    public float jumpingPower;
    
    private float _originalYSpeed;
    private float _horizontal;
    private bool _isFacingRight;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _originalYSpeed = yWalkingSpeed;
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Overworld")
        {
            yWalkingSpeed = _originalYSpeed;
        }
        else
        {
            yWalkingSpeed = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        
        Move();
    }
    
    private void Move()
    {
        rb.velocity = new Vector2(_horizontal * xWalkingSpeed * Time.deltaTime, rb.velocity.y);
        Flip();
        //transform.position += new Vector3(Input.GetAxis("Horizontal") * xWalkingSpeed * Time.deltaTime, Input.GetAxis("Vertical") * yWalkingSpeed * Time.deltaTime,0f);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, .02f, groundLayer);
    }

    private void Flip()
    {
        if (_isFacingRight && _horizontal < 0f || !_isFacingRight && _horizontal > 0f)
        {
            _isFacingRight = !_isFacingRight;
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
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * .5f * Time.deltaTime);
        }
    }

}

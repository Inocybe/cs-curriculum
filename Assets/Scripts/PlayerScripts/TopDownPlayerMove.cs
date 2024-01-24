using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownPlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    public float walkingSpeed;  

    private float _horizontal;
    private float _vertical;
    private Vector2 _inputVector;

    // Update is called once per frame
    void Update()
    {
        _inputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        rb.AddForce(_inputVector * walkingSpeed, ForceMode2D.Force);
    }
}

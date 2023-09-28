using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public Transform transform;
    
    public float walkingSpeed;
    private float xDirection;
    private float yDriection;
    private float originalSpeed;

    void Start()
    {
        originalSpeed = walkingSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        xDirection = Input.GetAxis("Horizontal");
        yDriection = Input.GetAxis("Vertical");

        if (xDirection + yDriection != 0)
        {
            walkingSpeed /= 2;
        }
        
        transform.position += new Vector3(xDirection * walkingSpeed * Time.deltaTime, yDriection * walkingSpeed * Time.deltaTime, 0);

        walkingSpeed = originalSpeed;
    }

}

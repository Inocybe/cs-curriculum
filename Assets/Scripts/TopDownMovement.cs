using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public Transform transform;
    
    public float walkingSpeed;
    private float xDirection;
    private float yDriection;

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void Move()
    {
        xDirection = Input.GetAxis("Horizontal");
        yDriection = Input.GetAxis("Vertical");
        
        transform.position += new Vector3(xDirection * walkingSpeed * Time.deltaTime, yDriection * walkingSpeed * Time.deltaTime, 0);
    }

}

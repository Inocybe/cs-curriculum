using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public new Transform transform;

    public float walkingSpeed;
 

    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * walkingSpeed * Time.deltaTime, Input.GetAxis("Vertical") * walkingSpeed * Time.deltaTime, 0f);
    }

}

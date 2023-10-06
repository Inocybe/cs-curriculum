using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementScritp : MonoBehaviour
{
    public new Transform transform;
    
    public float xWalkingSpeed;  
    public float yWalkingSpeed;
    public float jumpForce;
    private float originalYSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        originalYSpeed = yWalkingSpeed;
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Overworld")
        {
            yWalkingSpeed = originalYSpeed;
        }
        else
        {
            yWalkingSpeed = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * xWalkingSpeed * Time.deltaTime, Input.GetAxis("Vertical") * yWalkingSpeed * Time.deltaTime, 0f);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingScript : MonoBehaviour
{
    private SpriteRenderer sprite;
    
    
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        //if (sprite.flipX == )
    }
    
    
    
}

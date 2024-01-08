using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerShootingScript : MonoBehaviour
{
    [SerializeField] public GameObject fireball;
    
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        Vector2 mousePoint = (Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Vector2 shootDirection = new Vector2(mousePoint.x - transform.position.x, mousePoint.y - transform.position.y).normalized * speed;
        GameObject shot = Instantiate(fireball, transform.position, Quaternion.identity);
        shot.GetComponent<Rigidbody2D>().velocity = shootDirection;
    }
    
    
    
}

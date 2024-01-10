using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerShootingScript : MonoBehaviour
{
    [SerializeField] public GameObject fireball;

    public float shootCooldown;
    public float speed;

    private float _originalCooldown;

    private void Start()
    {
        _originalCooldown = shootCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        shootCooldown -= Time.deltaTime;
        
        if (Input.GetButtonDown("Fire1") && shootCooldown <= 0f)
        {
            Shoot();
            shootCooldown = _originalCooldown;
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

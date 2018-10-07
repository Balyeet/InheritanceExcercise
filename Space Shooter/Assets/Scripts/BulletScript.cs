using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed, lifeTime;
    public Rigidbody2D rBody2D;

    void Start()
    {
        rBody2D = GetComponent<Rigidbody2D>();

        if(rBody2D.transform.localScale.x < 0)
        {
            bulletSpeed = -bulletSpeed;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag != "Player")
        {
            Destroy(gameObject);
        }

    }

    void Awake()
    {
        Destroy(gameObject, lifeTime);
    }

}

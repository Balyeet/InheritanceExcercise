using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rBody2D;
 
    void Start()
    {
        rBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rBody2D.velocity = new Vector2(speed, 0);
    }
}

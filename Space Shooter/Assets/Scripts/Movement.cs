using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    Rigidbody2D rbody2D;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);

        if (transform.position.x > 8)
        {
            transform.position = new Vector2(8, transform.position.y);
        }

        if (transform.position.x < -8)
        {
            transform.position = new Vector2(-8, transform.position.y);
        }
    }
}

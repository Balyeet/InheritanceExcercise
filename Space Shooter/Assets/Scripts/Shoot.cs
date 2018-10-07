using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet, effect;
    public bool right = true;
    public Transform firePoint, firePoint2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (right)
            {
                Transform skott = Instantiate(bullet, firePoint.position, firePoint.rotation).transform;
                Transform particle = Instantiate(effect, firePoint.position, firePoint.rotation).transform;

                Transform skott2 = Instantiate(bullet, firePoint2.position, firePoint2.rotation).transform;
                Transform particle2 = Instantiate(effect, firePoint2.position, firePoint2.rotation).transform;
            }
        }

    }
}

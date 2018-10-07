using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillParticle : MonoBehaviour
{
    public float destroy;

    // Use this for initialization
    void Start()
    {
        Invoke("Die", destroy);
    }

    // Update is called once per frame
    void Die()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
    public GameObject effect;

    void Start()
    {
        SetMaxHealth();
    }

    void Update()
    {
        if(CurrentHealth <= 0)
        {
            Transform particle = Instantiate(effect, transform.position, transform.rotation).transform;
            Destroy(gameObject);
        }
    }

    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
}

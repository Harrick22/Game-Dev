using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{

    public int maxhealth = 100;
    int currentHealth;

    void Start()
    {
        currentHealth = maxhealth;
    }

    public void TakeDamage(int damage)
    {
        maxhealth -= damage;

        if (maxhealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {

    }

}
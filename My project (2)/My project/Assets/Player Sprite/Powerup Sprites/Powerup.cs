using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public float multiplier = 1.4f;
    public GameObject pickupEffect;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerHealth stats = player.GetComponent<PlayerHealth>();
        stats.currentHealth = Mathf.Min(Mathf.RoundToInt(stats.currentHealth * multiplier), stats.maxhealth);
 
         Destroy(gameObject);
    }
}

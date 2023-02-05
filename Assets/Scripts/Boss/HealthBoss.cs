using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoss : MonoBehaviour
{
    int health = 200;

    public void Damage(int value)
    {
        health -= value;
        if (health <= 0) Defeated();
    }

    private void Defeated()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Attack"))
        {
            Damage(10);
        }
    }
}

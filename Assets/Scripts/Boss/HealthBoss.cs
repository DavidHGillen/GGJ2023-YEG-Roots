using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoss : MonoBehaviour
{
    int health;

    public void Damage(int value)
    {
        health -= value;
        if (health <= 0) Defeated();
    }

    private void Defeated()
    {
    }
}

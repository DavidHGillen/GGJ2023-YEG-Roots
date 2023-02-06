using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthBoss : MonoBehaviour
{
    int health = 200;
    public bool isBoss;

    public void Damage(int value)
    {
        health -= value;
        if (health <= 0) Defeated();
    }

    private void Defeated()
    {
       if(!isBoss) Destroy(gameObject);
        else SceneManager.LoadScene("EndScene");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Attack"))
        {
            Damage(10);
        }
    }
}

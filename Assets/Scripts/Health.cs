using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health = 100;
    public Image barFill;

    public void ReceiveDamage(int value)
    {
        health-=value;
        UpdateBar();
        if (health <= 0)
        {
            GameOver();                
        }
    }

    public void Heal(int value)
    {
        health += value;
        UpdateBar();
    }

    public void GameOver()
    {

    }

    public void UpdateBar()
    {
        Debug.Log("Called"+ (float) health / 100);
        barFill.fillAmount = (float)health /100;
    }
}

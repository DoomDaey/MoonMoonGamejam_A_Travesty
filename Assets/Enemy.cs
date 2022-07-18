using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 1;

    private void Update()
    {
        if (Health <= 0)
        {
            gameObject.SetActive(false);
        }
        
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}

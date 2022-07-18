using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 1;
    public int maxHealth = 5;
    public GameObject gameOverUI;

    private void Update()
    {
        if (health <= 0)
        {
            if (gameObject.tag == "Player")
            {
                gameOverUI.SetActive(true);
                health = maxHealth;
                gameObject.transform.position = new Vector3(0, 0, 0);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}

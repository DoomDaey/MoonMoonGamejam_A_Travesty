using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 1;
    public int maxHealth = 3;
    public GameObject gameOverUI;
    public string deathSoundToPlay;
    public string hurtSoundToPlay;
    public GameObject DeathParticles;

    private void Update()
    {
        if (health <= 0)
        {
            if (gameObject.tag == "Player")
            {
                FindObjectOfType<AudioManager>().Play("PlayerDeath");
                gameOverUI.SetActive(true);
                health = maxHealth;
                gameObject.transform.position = new Vector3(0, 0, 0);
            }
            else
            {
                FindObjectOfType<AudioManager>().Play(deathSoundToPlay);
                Instantiate(DeathParticles, transform.position, Quaternion.identity);
                gameObject.SetActive(false);
            }
        }
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (gameObject.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("PlayerHurt");
        }
        else
        {
            if (health != 0 && hurtSoundToPlay != null)
            {
                FindObjectOfType<AudioManager>().Play(hurtSoundToPlay);
            }
        }
    }
}

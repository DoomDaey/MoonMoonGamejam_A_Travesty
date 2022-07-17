using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEnemyStack : MonoBehaviour
{
    public GameObject enemyStackToEnable;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "Player")
        {
            enemyStackToEnable.SetActive(true);
        }
    }
}

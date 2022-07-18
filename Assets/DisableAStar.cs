using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAStar : MonoBehaviour
{
    public GameObject lvl1Enemies;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            lvl1Enemies.SetActive(false);
        }
    }
}

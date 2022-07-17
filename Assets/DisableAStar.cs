using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAStar : MonoBehaviour
{
    public GameObject aStar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "Player")
        {
        aStar.SetActive(false);

        }
    }
}

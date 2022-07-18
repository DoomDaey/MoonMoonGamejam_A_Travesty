using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEndComic : MonoBehaviour
{
    public GameObject finalComic;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            finalComic.SetActive(true);
        }
    }
}

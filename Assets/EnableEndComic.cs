using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEndComic : MonoBehaviour
{
    public GameObject finalComic;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            finalComic.SetActive(true);
        }
        
    }
}

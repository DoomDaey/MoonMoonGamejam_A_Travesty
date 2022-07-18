using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAStar2 : MonoBehaviour
{
    public GameObject enemieToDisable;
    public GameObject enemiesToEnable;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            enemieToDisable.SetActive(false);
            enemiesToEnable.SetActive(true);
            FindObjectOfType<AudioManager>().StopPlaying("HellForest");
            FindObjectOfType<AudioManager>().Play("Devour");
            Destroy(this.gameObject);
        }
    }
}

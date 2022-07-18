using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeBullet : MonoBehaviour
{
    private void OnEnable()
    {
        Destroy(gameObject, 60f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            return;
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<Health>().TakeDamage(1);
        }
        if (collision.gameObject.tag == "PlayerBullet")
        {
            Destroy(collision.gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AI : MonoBehaviour
{
    private AIDestinationSetter aiDestinationSetter;

    private void OnEnable()
    {
        aiDestinationSetter = GetComponent<AIDestinationSetter>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            aiDestinationSetter.target = collision.transform;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(collision.gameObject.name);
            Destroy(this.gameObject);
        }
    }
}

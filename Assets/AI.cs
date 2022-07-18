using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AI : MonoBehaviour
{
    private AIDestinationSetter aiDestinationSetter;
    public SceneControllerManager sceneControllerManager;

    private void OnEnable()
    {
        aiDestinationSetter = GetComponent<AIDestinationSetter>();
        sceneControllerManager = FindObjectOfType<SceneControllerManager>();
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
            collision.gameObject.GetComponent<Health>().TakeDamage(1);
        }
    }
}

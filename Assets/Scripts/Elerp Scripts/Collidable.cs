using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D contactFilter;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];

    protected void OnEnable()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        
    }
    protected virtual void Update()
    {
        // Collision work 
        boxCollider.OverlapCollider(contactFilter, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
            {

                continue;
            }
            onCollide(hits[i]);

            //Clean array
            hits[i] = null;
        }
    }

    protected virtual void onCollide(Collider2D collision)
    {
        Debug.Log(collision.name);
    }
}

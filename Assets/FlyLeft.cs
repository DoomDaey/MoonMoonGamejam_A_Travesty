using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLeft : MonoBehaviour
{
    public float travelSpeed = 10.0f;
    private Rigidbody2D rb;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.left * Time.deltaTime * travelSpeed);
    }
}

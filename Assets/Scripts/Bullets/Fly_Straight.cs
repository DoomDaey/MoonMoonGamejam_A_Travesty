using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly_Straight : MonoBehaviour
{
    public float bulletSpeed = 10.0f;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * bulletSpeed);
    }
}

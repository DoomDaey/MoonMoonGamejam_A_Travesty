using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    public Transform[] projectileSpawnPoints;
    public GameObject axePrefab;
    private Transform transformToThrowFrom;
    [SerializeField]
    private float nextTimeToFire = 1;
    private float fireRate = 0.2f;
    private Health health;

    private void OnEnable()
    {
        health = GetComponent<Health>();
    }

    private void Update()
    {
        if (Time.time > nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1 / fireRate - ((health.maxHealth - health.health) / 10);
            ThrowAxe();
        }
    }

    private void ThrowAxe()
    {
        transformToThrowFrom = projectileSpawnPoints[Random.Range(0, projectileSpawnPoints.Length)];
        GameObject newObject = Instantiate(axePrefab, transformToThrowFrom.position, Quaternion.identity, transform.parent = null);
        newObject.transform.localScale = new Vector3 (1, 2, 1);
    }

}

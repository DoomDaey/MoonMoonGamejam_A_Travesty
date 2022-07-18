using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    public Transform[] projectileSpawnPoints;
    public GameObject axePrefab;
    private Transform transformToThrowFrom;
    [SerializeField]
    private float fireRate;

    private void ThrowAxe()
    {
        transformToThrowFrom = projectileSpawnPoints[Random.Range(0, projectileSpawnPoints.Length)];
        Instantiate(axePrefab, transformToThrowFrom);
    }

    private IEnumerator ThrowAxeCoroutine()
    {
        ThrowAxe();


        yield return new WaitForEndOfFrame();
    }
}

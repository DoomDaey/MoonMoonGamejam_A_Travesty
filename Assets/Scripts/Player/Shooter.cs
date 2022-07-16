using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    private bool canShoot = true;
    public float shootCooldown = 0.5f;

    private void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (canShoot)
            {
                Shoot();
                canShoot = false;
                StartCoroutine(ShootingCooldown());
            }
        }
    }

    private IEnumerator ShootingCooldown()
    {
        yield return new WaitForSeconds(shootCooldown);
        canShoot = true;
    }
}

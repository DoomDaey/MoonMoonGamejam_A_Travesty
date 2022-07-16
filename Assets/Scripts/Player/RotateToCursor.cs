using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCursor : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 direction;
    private new Camera camera;
    private Rigidbody2D playerRgidbody2D;

    private void Start()
    {
        playerRgidbody2D = GetComponent<Rigidbody2D>();
        camera = FindObjectOfType<Camera>();
    }

    private void Update()
    {
        RotateToCamera();
    }

    void RotateToCamera()
    {
        mousePosition = camera.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z - camera.transform.position.z));
        playerRgidbody2D.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mousePosition.y - transform.position.y), (mousePosition.x - transform.position.x)) * Mathf.Rad2Deg -90);
    }
}

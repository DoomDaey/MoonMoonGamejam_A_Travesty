using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isMoving = false;
    public bool disablePlayerMovement = true;
    private bool isPressingW;
    private bool isPressingS;
    private bool isPressingA;
    private bool isPressingD;
    public float speed = 5.0f;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if (!disablePlayerMovement)
        {
            Movement();
        }
    }
    private void Update()
    {
        isPressingW = Input.GetKey(KeyCode.W);
        isPressingS = Input.GetKey(KeyCode.S);
        isPressingA = Input.GetKey(KeyCode.A);
        isPressingD = Input.GetKey(KeyCode.D);
    }

    private void Movement()
    {
        if (isPressingW)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
            isMoving = true;
        }

        if (isPressingS)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
            isMoving = true;
        }

        if (isPressingA)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            isMoving = true;
            // Face left
            spriteRenderer.flipX = true;
        }

        if (isPressingD)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
            isMoving = true;
            // Face right
            spriteRenderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.D) != true && Input.GetKey(KeyCode.A) != true && Input.GetKey(KeyCode.S) != true && Input.GetKey(KeyCode.W) != true )
        {
            isMoving = false;
        }
    }
}

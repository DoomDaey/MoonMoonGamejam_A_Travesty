using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraPan : MonoBehaviour
{
    private Vector3 mousePosition;
    private new Camera camera;
    private CinemachineCameraOffset offset;

    private void Start()
    {
        offset = GetComponent<CinemachineCameraOffset>();
        camera = FindObjectOfType<Camera>();

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            offset.m_Offset.x = 10;
        }
    }
}

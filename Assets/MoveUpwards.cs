using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpwards : MonoBehaviour
{
    public GameObject credits;
    public GameObject comic1;
    public GameObject comic2;
    public GameObject comic3;


    private void Update()
    {
        credits.transform.Translate(Vector3.up * 0.5f);
        comic1.transform.Translate(Vector3.up * 0.5f);
        comic2.transform.Translate(Vector3.up * 0.5f);
        comic3.transform.Translate(Vector3.up * 0.5f);

    }
}

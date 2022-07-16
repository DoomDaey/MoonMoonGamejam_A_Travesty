using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Advance_Level_Portal : MonoBehaviour
{
    private SceneControllerManager sceneControllerManager;
    [SerializeField]
    private Vector3 nextLevelStartPos;

    private void OnEnable()
    {        
        sceneControllerManager = FindObjectOfType<SceneControllerManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            sceneControllerManager.AdvanceScene();
            Destroy(gameObject);
            collision.transform.position = nextLevelStartPos;
        }
    }
}

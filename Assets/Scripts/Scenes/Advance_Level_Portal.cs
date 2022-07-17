using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Advance_Level_Portal : MonoBehaviour
{
    private SceneControllerManager sceneControllerManager;
    [SerializeField]
    private Vector3 nextLevelStartPos;
    [SerializeField]
    private GameObject enemyStack1;
    [SerializeField]
    private GameObject enemyStack2;


    private void OnEnable()
    {        
        sceneControllerManager = FindObjectOfType<SceneControllerManager>();
        enemyStack1 = GameObject.Find("Enemies_Lvl_1");
        enemyStack2 = GameObject.Find("Enemies_Lvl_2");
        enemyStack2.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            sceneControllerManager.AdvanceScene();
            if (enemyStack1 != null)
            {
                enemyStack1.SetActive(false);
            }
            Destroy(gameObject);
            collision.transform.position = nextLevelStartPos;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControllerManager : MonoBehaviour
{
    public int currentSceneIndex;

    private void OnEnable()
    {
    }

    private void Start()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(1));
        currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        
    }

    private void Update()
    {
        Debug.Log(currentSceneIndex);

        if (Input.GetKeyDown(KeyCode.T))
        {
            AdvanceScene();
        }
    }

    public void AdvanceScene()
    {
        // Unload current scene
        SceneManager.UnloadScene(currentSceneIndex);
        // Load next scene additively
        SceneManager.LoadScene(currentSceneIndex + 1);
        currentSceneIndex++;
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(currentSceneIndex));
    }
}

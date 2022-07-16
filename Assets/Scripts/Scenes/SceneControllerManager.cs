using System;
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

    public void AdvanceScene()
    {
        // Load next scene additively
        SceneManager.LoadSceneAsync(currentSceneIndex + 1, LoadSceneMode.Additive);
        StartCoroutine(WaitForSceneLoad(AfterSceneUnloadWait));
    }

    IEnumerator WaitForSceneLoad(Action action)
    {
        yield return new WaitForSeconds(0.5f);
        action();
    }

    private void AfterSceneUnloadWait()
    {
        // Unload current scene
        SceneManager.UnloadSceneAsync(currentSceneIndex);
        currentSceneIndex++;
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(currentSceneIndex));

    }
}

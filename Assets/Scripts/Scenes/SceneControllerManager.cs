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
        SceneManager.LoadScene(currentSceneIndex + 1, LoadSceneMode.Additive);
        currentSceneIndex = 1;
    }

    private void Start()
    {
        StartCoroutine(WaitForSceneLoad(AfterWait));
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
        yield return new WaitForSeconds(1f);
        action();
    }

    private void AfterSceneUnloadWait()
    {
        // Unload current scene
        SceneManager.UnloadSceneAsync(currentSceneIndex);
        currentSceneIndex++;
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(currentSceneIndex));

    }

    private void AfterWait()
    {

    }
}

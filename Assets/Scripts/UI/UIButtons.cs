using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject startUpScreen;
    [SerializeField]
    private GameObject shooter;

    private void Start()
    {

    }

    public void OnStartGame()
    {
        startUpScreen.SetActive(false);
        shooter.SetActive(true);
    }

    public void OnQuitGame()
    {
        Application.Quit();
    }
}

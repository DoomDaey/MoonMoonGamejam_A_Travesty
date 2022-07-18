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
    [SerializeField]
    private GameObject player;
    private PlayerMovement playerMovement;
    public GameObject slideshowToEnable;

    private void Start()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    public void OnStartGame()
    {
        startUpScreen.SetActive(false);
        shooter.SetActive(true);
        playerMovement.disablePlayerMovement = false;
        slideshowToEnable.SetActive(true);
    }

    public void OnQuitGame()
    {
        Application.Quit();
    }
}

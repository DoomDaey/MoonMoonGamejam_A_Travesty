using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject UI;
    public GameObject GameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(true);
        GameOverUI.SetActive(false);
    }


}

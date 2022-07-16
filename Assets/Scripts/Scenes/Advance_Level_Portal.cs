using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Advance_Level_Portal : Collidable
{
    protected override void onCollide(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            //UnityEngine.SceneManagement.SceneManager.LoadScene()
        }
    }
}

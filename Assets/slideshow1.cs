using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class slideshow1 : MonoBehaviour
{

    public Texture[] imageArray;
    public string[] stringArrayOfSoundsToPlay;
    public int currentImage;
    public int lastSoundThatPlayedIndex;

    float deltaTime = 0.0f;

    public float timer1 = 5.0f;
    public float timer1Remaining = 5.0f;
    public bool timer1IsRunning = true;
    public string timer1Text;


    // added ergonomic functionality,
    // escape key to exit,
    // p key or right mouse to pause the timer1
    // left mouse or spacebar to skip to next slide

    void OnGUI()
    {

        int w = Screen.width, h = Screen.height;

        Rect imageRect = new Rect(0, 0, Screen.width, Screen.height);

        //dont need to make button transparent but would be cool to know how to.
        //Rect buttonRect = new Rect(0, Screen.height - Screen.height / 10, Screen.width, Screen.height / 10);

        //GUI.Label(imageRect, imageArray[currentImage]);
        //Draw texture seems more elegant
        GUI.DrawTexture(imageRect, imageArray[currentImage]);

        //if(GUI.Button(buttonRect, "Next"))
        //currentImage++;

        if (currentImage >= imageArray.Length)
            gameObject.SetActive(false);
    }

    private void playSoundBasedOnString(string soundString)
    {
        FindObjectOfType<AudioManager>().Play(stringArrayOfSoundsToPlay[currentImage]);
    }

    // Start is called before the first frame update
    void Start()
    {
        currentImage = 0;
        timer1Remaining = timer1;

        if (stringArrayOfSoundsToPlay[currentImage] != null)
        {
            playSoundBasedOnString(stringArrayOfSoundsToPlay[currentImage]);
            lastSoundThatPlayedIndex = currentImage;
        }
    }

    private IEnumerator WaitForCoroutine()
    {
        yield return new WaitForSeconds((float)(timer1Remaining - 1));

        FindObjectOfType<AudioManager>().StopAllAudio();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FindObjectOfType<AudioManager>().StopPlaying("HappyHome");
            FindObjectOfType<AudioManager>().StopPlaying("Devour");
            FindObjectOfType<AudioManager>().StopPlaying("Lumber");
            FindObjectOfType<AudioManager>().Play("Forest");
            gameObject.SetActive(false);
        }



        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Debug.Log("Pressed space bar.");
            currentImage++;

            if (stringArrayOfSoundsToPlay[currentImage] != null)
            {
                playSoundBasedOnString(stringArrayOfSoundsToPlay[currentImage]);
                lastSoundThatPlayedIndex = currentImage;

            }

            if (currentImage >= imageArray.Length)
                gameObject.SetActive(false);
        }

        if (timer1IsRunning)

        {
            if (timer1Remaining > 0)
            {
                timer1Remaining -= Time.deltaTime;

            }

            else
            {
                UnityEngine.Debug.Log("Time has run out!");

                currentImage++;

                if (stringArrayOfSoundsToPlay[currentImage] != null)
                {
                    playSoundBasedOnString(stringArrayOfSoundsToPlay[currentImage]);
                }


                if (currentImage >= imageArray.Length)
                {
                    currentImage = 0;
                    gameObject.SetActive(false);
                }

                timer1Remaining = timer1;
            }
        }
        // Disable all Songs manually since im too dumb
        if (currentImage == 12 && timer1Remaining <= 1f)
        {
            FindObjectOfType<AudioManager>().StopPlaying("Lumber");
        }

        if (currentImage == 14 && timer1Remaining <= 1f)
        {
            FindObjectOfType<AudioManager>().StopPlaying("Devour");
        }

        if (currentImage == 18 && timer1Remaining <= 1f)
        {
            FindObjectOfType<AudioManager>().StopPlaying("Devour");
        }

        if (currentImage == 30 && timer1Remaining <= 1f)
        {
            FindObjectOfType<AudioManager>().StopPlaying("HappyHome");
        }

        if (currentImage == 32 && timer1Remaining <= 1f)
        {
            FindObjectOfType<AudioManager>().StopPlaying("Devour");
        }

        if (currentImage == 33 && timer1Remaining <= 1f)
        {
            FindObjectOfType<AudioManager>().StopPlaying("HappyHome");
            FindObjectOfType<AudioManager>().StopPlaying("Devour");
            FindObjectOfType<AudioManager>().StopPlaying("Lumber");
            FindObjectOfType<AudioManager>().Play("Forest");
            gameObject.SetActive(false);

        }

    }
}

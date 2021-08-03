using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource mainMusic;
    public GameObject pauseScreen;

    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            if(gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;
                mainMusic.Pause();
                pauseScreen.SetActive(true);
            }
            else
            {
                pauseScreen.SetActive(false);
                mainMusic.UnPause();
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }
}

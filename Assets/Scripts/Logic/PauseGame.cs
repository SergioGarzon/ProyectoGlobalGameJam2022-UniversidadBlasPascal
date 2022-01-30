using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame: MonoBehaviour
{

    public static bool paused = false;

    public GameObject pauseMenu;
       

    public void Pause()
    {
        if (!Input.GetKeyDown("space"))
        {
            if (!paused)
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                pauseMenu.SetActive(false);
                Time.timeScale = 1f;
            }
            paused = !paused;
        }
    }

    public void exitGame()
    {
        if (!Input.GetKeyDown("space"))
            SceneManager.LoadScene("StartMenu");
    }
}
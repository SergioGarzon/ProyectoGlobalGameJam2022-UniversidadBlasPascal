using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void ChangeScene(string name)
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("contadorRings", 0);
        PlayerPrefs.SetInt("contador", 3);

        SceneManager.LoadScene(name);
    }

    public void QuitGame()
    {
        PlayerPrefs.SetInt("Music", 1);

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
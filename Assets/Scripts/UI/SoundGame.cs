using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGame : MonoBehaviour
{
    public AudioSource audioG;

    void Start()
    {
        StartAudio();
    }

    public void StartAudio()
    {
        float volumen = PlayerPrefs.GetFloat("Music", 0f);
        audioG.volume = volumen;
        audioG.Play();
    }

    public void Stop()
    {
        audioG.Stop();
    }
}

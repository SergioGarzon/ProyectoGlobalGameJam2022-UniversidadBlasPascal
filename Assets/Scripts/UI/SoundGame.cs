using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGame : MonoBehaviour
{
    public AudioSource audioG;

    public void StartAudio()
    {
        audioG.Play();
    }

    public void Stop()
    {
        audioG.Stop();
    }
}

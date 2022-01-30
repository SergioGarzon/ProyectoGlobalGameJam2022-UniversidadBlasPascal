using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVolumen : MonoBehaviour
{
    public Slider sldVolumen;

    public void StartVolumen()
    {
        sldVolumen.value = PlayerPrefs.GetFloat("Music", 0.0f); 
    }

    public void SaveVolumen()
    {
        PlayerPrefs.SetFloat("Music", sldVolumen.value);
        PlayerPrefs.Save();
    }
}
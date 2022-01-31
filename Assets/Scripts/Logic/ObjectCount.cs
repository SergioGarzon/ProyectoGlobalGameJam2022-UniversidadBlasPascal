using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCount : MonoBehaviour
{
    public Text text;


    void Update()
    {
        int contador = PlayerPrefs.GetInt("contadorRings", 0);
        text.text = contador + "";
    }

}

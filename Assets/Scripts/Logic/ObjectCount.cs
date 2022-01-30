using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCount : MonoBehaviour
{
    public static ObjectCount instance;
    public Text text;
    public int score = 0;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void changeScore(int value)
    {
        score += value;
        text.text = score.ToString();
    }

}

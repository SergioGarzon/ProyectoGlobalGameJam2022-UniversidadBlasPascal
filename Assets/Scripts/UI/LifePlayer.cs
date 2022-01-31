using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePlayer : MonoBehaviour
{
    public Text txtLife;
    private bool control;
    public GameObject pnlUI;
    public GameObject pnlGameOver;

    void Start()
    {
        control = true;
    }


    void Update()
    {
        int contador = PlayerPrefs.GetInt("contador", 0);

        txtLife.text = contador + "";

        if(contador == 0 && control)
        {
            control = false;
            Time.timeScale = 0f;
            pnlUI.gameObject.SetActive(false);
            pnlGameOver.gameObject.SetActive(true);
        }
    }
}

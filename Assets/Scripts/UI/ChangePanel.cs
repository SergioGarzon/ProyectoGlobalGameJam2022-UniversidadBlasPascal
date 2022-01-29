using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    public void OpenPanel()
    {
        panel1.gameObject.SetActive(false);
        panel2.gameObject.SetActive(true);
    }

}

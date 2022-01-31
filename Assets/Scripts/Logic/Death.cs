using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private int contador = 3;

    void Start()
    {
        contador = PlayerPrefs.GetInt("contador", 3);
    }


    // collides with object tagged death
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "floorDead")
        {
            contador--;
            PlayerPrefs.SetInt("contador", contador);
            Die();
        }
    }

    // kills player and resets
    void Die()
    {        
        
        

        contador = PlayerPrefs.GetInt("contador", 0);

        if(contador != 0)
        {
            Destroy(transform.parent.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


    }
}

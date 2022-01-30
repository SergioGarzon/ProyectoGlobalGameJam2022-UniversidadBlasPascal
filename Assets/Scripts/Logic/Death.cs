using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private int contador = 3;


    // collides with object tagged death
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "floorDead")
        {
            Die();
        }
    }

    // kills player and resets
    void Die()
    {
        if(contador == 0)


        Destroy(transform.parent.gameObject);
        contador--;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

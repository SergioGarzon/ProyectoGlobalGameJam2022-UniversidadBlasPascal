using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
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
        Destroy(transform.parent.gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

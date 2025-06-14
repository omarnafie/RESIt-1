using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Snail : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject); // Player dies
            FindObjectOfType<ScoreManager>().GameOver();
        }
        else if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject); // Destroy bullet
            Destroy(gameObject);       // Destroy snail
        }
    }
}

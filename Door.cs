using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    public int requiredKeys = 1; // Set this per door in Inspector
    public GameObject doorVisual; // Optional: door sprite to destroy

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            movement player = other.GetComponent<movement>();
            if (player != null)
            {
                if (player.keyCount >= requiredKeys)
                {
                    if (doorVisual != null)
                    {
                        Destroy(doorVisual); // Only destroy visual if needed
                    }
                    else
                    {
                        Destroy(gameObject);
                    }
                }
                else
                {
                    Destroy(other.gameObject); // Player dies
                    FindObjectOfType<ScoreManager>().GameOver();
                }
            }
        }
    }

}




using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            movement player = other.GetComponent<movement>();
            if (player != null)
            {
                player.AddKey(); 
                Destroy(gameObject); // Remove the key from the scene
            }
        }
    }
}


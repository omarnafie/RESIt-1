using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 3f;

    void Start()
    {
        // Auto-destroy bullet after a few seconds if it doesn't hit anything
        //Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // Move bullet forward (to the right)
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        

        // Destroy enemy (like snail)
        if (other.CompareTag("Snail"))
        {
            Destroy(other.gameObject);
        }

        
    }
}




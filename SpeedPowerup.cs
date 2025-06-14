using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpeedPowerup : MonoBehaviour
{
    public float boostAmount = 10f;
    public float duration = 20f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            movement player = other.GetComponent<movement>();
            if (player != null)
            {
                player.ActivateSpeedBoost(boostAmount, duration);
                Destroy(gameObject); // remove the power-up
            }
        }
    }
}


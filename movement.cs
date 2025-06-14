using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour
{
    public float speed = 2f;                 
    public float jumpForce = 5f;             
    public Renderer renderObject;

    public bool hasKey = false;
    public int keyCount = 0;                 

    private float defaultSpeed;              
    private Coroutine speedBoostRoutine;     

    private Rigidbody2D rb;
    private bool isGrounded = false;

    public Transform groundCheck;
    public LayerMask groundLayer;
    public float checkRadius = 0.15f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultSpeed = speed; // Store initial speed for reset
    }

    void Update()
    {
        // Scroll background
        renderObject.material.mainTextureOffset += new Vector2(0f, speed * Time.deltaTime);

        // Move the player forward automatically
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        // Ground check
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);
    }

    // Jump function (called by UI button)
    public void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    // Add key (for key-door logic)
    public void AddKey()
    {
        keyCount++;
    }

    // Activate speed boost for a set duration
    public void ActivateSpeedBoost(float boostAmount, float duration)
    {
        if (speedBoostRoutine != null)
            StopCoroutine(speedBoostRoutine);

        speedBoostRoutine = StartCoroutine(SpeedBoost(boostAmount, duration));
    }

    private IEnumerator SpeedBoost(float boostAmount, float duration)
    {
        Debug.Log("Speed boosted to " + boostAmount);
        speed = boostAmount;
        yield return new WaitForSeconds(duration);
        speed = defaultSpeed;
        Debug.Log("Speed returned to normal");
    }

    // Draw ground check circle in Scene view
    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, checkRadius);
        }
    }
}

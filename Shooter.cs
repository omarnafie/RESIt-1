using UnityEngine;
using UnityEngine.EventSystems; // Add this for UI check

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float bulletOffset = 0.2f;

    void Update()
    {
        // Tap on screen (or mouse click in editor), ignoring UI
        if (Input.GetMouseButtonDown(0) && (EventSystem.current == null || !EventSystem.current.IsPointerOverGameObject()))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Vector3 spawnPos = firePoint.position + firePoint.right * bulletOffset;

        Instantiate(bulletPrefab, spawnPos, firePoint.rotation);

    //    Collider2D playerCollider = GetComponent<Collider2D>();
    //    Collider2D bulletCollider = bullet.GetComponent<Collider2D>();

    //    if (playerCollider != null && bulletCollider != null)
    //    {
    //        Physics2D.IgnoreCollision(playerCollider, bulletCollider);
    //    }
    }
}

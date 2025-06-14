using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailSpawner : MonoBehaviour
{
    public GameObject snailPrefab;
    public Transform spawnPoint;
    public float spawnInterval = 5f;

    private void Start()
    {
        InvokeRepeating("SpawnSnail", 5f, spawnInterval);
    }

    void SpawnSnail()
    {
        Instantiate(snailPrefab, spawnPoint.position, Quaternion.identity);
    }
}


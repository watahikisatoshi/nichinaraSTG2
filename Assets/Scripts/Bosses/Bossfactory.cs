using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossfactory : MonoBehaviour
{
    public GameObject enemyPrefab;

    void Start()
    {

        InvokeRepeating("Spawn", 1f, 0.5f);

    }

    void Spawn()
    {
        Vector3 spawnPosition = new Vector3(
            transform.position.x,
            Random.Range(-4f,4f),
            transform.position.z
            );
        Instantiate(enemyPrefab, spawnPosition, transform.rotation);
    }
}


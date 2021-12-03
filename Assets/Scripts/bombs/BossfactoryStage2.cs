using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossfactoryStage2 : MonoBehaviour
{
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1f, 0.5f);
    }

    void Spawn()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-9f, 9f),
            transform.position.y,
            transform.position.z
            );
        Instantiate(enemyPrefab, spawnPosition, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

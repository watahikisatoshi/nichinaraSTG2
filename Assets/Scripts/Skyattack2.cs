using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyattack2 : MonoBehaviour
{

    public GameObject rockPrefab;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("GenRock", 1, 1);

    }

    void GenRock()
    {

        Instantiate(rockPrefab, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    }
}
        
    


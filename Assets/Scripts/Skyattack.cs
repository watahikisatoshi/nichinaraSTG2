using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyattack : MonoBehaviour
{

    float fallspeed;
    float rotspeed;


    // Start is called before the first frame update
    void Start()
    {

        this.fallspeed = 0.01f + 0.1f * Random.value;
        this.rotspeed = 5f + 3f * Random.value;

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, -fallspeed, 0, Space.World);
        transform.Rotate(0, 0, rotspeed);

        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);

        }
    }
}

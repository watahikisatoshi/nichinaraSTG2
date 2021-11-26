using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerController : MonoBehaviour
{
    [SerializeField] private float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector3 lazerPos = transform.position;
        lazerPos.x += speed  *Time.deltaTime;
        transform.position = lazerPos;
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscroll : MonoBehaviour

{
    [SerializeField] private float scrollSpead;
    [SerializeField] private float startLine;
    [SerializeField] private float deadline;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    public void Scroll()
    {
        transform.Translate(scrollSpead, 0, 0);

        if (transform.position.x < deadline)
        {
            transform.position = new Vector3(startLine, 0, 0);
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosscontroller2 : MonoBehaviour
{

    public GameObject Bosscontroller;
    public int speed = 5;
    Vector3 movePosition;


    // Start is called before the first frame update
    void Start()
    {
        movePosition = moveRandomPosition();
    }

    // Update is called once per frame
    void Update()
        {
            if (movePosition == Bosscontroller.transform.position)
            {
                movePosition = moveRandomPosition();

            }

            this.Bosscontroller.transform.position = Vector3.MoveTowards(Bosscontroller.transform.position, movePosition, speed * Time.deltaTime);

        }

        private Vector3 moveRandomPosition()

        {

            Vector3 randomPosi = new Vector3(Random.Range(7,7), Random.Range(-4, 5), 5);
            return randomPosi;

        }
    }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosscontroller : MonoBehaviour
{
    private float time;

    public GameObject BossBullet;
    public int speed = 5;
    Vector3 movePosition;



    // Start is called before the first frame update
    void Start()
    {
        movePosition = moveRandomPosition();

        InvokeRepeating("Shot", 2f, 1f);
    }

    void Shot()
    {

        Instantiate(BossBullet, transform.position, transform.rotation);
    }
        // Update is called once per frame
        void Update()
        {
            
            if(movePosition == BossBullet.transform.position)

            {
                movePosition = moveRandomPosition();
            }

            this.BossBullet.transform.position = Vector3.MoveTowards(BossBullet.transform.position, movePosition, speed * Time.deltaTime);

        }

    private Vector3 moveRandomPosition()

    {

        Vector3 randomPosi = new Vector3(Random.Range(-6,6),Random.Range(-6,6),5);
        return randomPosi;

    }

        

    
}
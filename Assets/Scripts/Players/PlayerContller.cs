using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContller : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] public float maxY, minY;
    [SerializeField] public float maxX, minX;
    [SerializeField] private GameObject lazer;
    [SerializeField] private Transform attackPoint;
    [SerializeField] private float attackTime = 0.2f;
    private float currentAttackTime;
    private bool canAttack;

    // Start is called before the first frame update
    void Start()
    {
        currentAttackTime = attackTime;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Attack();
    }

    void MovePlayer()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            Vector3 playerPos = transform.position;
            playerPos.y += speed * Time.deltaTime;
            if(maxY < playerPos.y)
            {
                playerPos.y = maxY;
            }
            transform.position = playerPos;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            Vector3 playerPos = transform.position;
            playerPos.y -= speed * Time.deltaTime;
            if (minY > playerPos.y)
            {
                playerPos.y = minY;
            }
            transform.position = playerPos;
        }


        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            Vector3 playerPos = transform.position;
            playerPos.x += speed * Time.deltaTime;
            if (maxX < playerPos.x)
            {
                playerPos.x = maxX;
            }
            transform.position = playerPos;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Vector3 playerPos = transform.position;
            playerPos.x -= speed * Time.deltaTime;
            if (minX > playerPos.x)
            {
                playerPos.x = minX;
            }
            transform.position = playerPos;
        }
    }

    void Attack()
    {
        attackTime += Time.deltaTime;
        if(attackTime > currentAttackTime)
        {
            canAttack = true;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (canAttack)
            {
                Instantiate(lazer, attackPoint.position, Quaternion.identity);
                canAttack = false;
                attackTime = 0f;

                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }



}


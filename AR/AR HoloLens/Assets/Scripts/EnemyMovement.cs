using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public float speed = 3f;
    public float maxSpeed = 5f;
    public float minSpeed = 1f;
    private Vector3 targetPosition;
    public bool isWalking;
    private Vector3 playerPosition;

    public AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        isWalking = true;
        
    }

    private void EnemyMoving()
    {
        playerPosition = GameObject.Find("Player").transform.position;
        targetPosition = playerPosition;
        

        transform.LookAt(targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, (speed / 5f) * Time.deltaTime);

    }

    //When "Bullet" hits enemy they will be destroyed
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            DestroyEnemy();
            
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        }
    }

    void DestroyEnemy()
    {
        Destroy(this.gameObject.GetComponent<MeshRenderer>());
        Destroy(this.gameObject.GetComponent<CapsuleCollider>());
        Destroy(this.gameObject.GetComponent<BoxCollider>());
    }
    

    // Update is called once per frame
    void Update()
    {

        if (isWalking)
        {
            EnemyMoving();
        }



    }
}
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace HoloToolkit.Unity.InputModule.Tests
{

    public class Shooting : MonoBehaviour, IInputHandler

    {
        public GameObject Bullet;
        public GameObject ShootPlace;
        public float Bullet_Force;
        public AudioSource audioSource;

        public AudioClip puckPistolShot;

        private void Start()
        {
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.clip = puckPistolShot;
        }



        public void OnInputDown(InputEventData eventData)
        {
            PuckPistol();
            audioSource.Play();
        }

        public void OnInputUp(InputEventData eventData)
        {

        }
        

        void PuckPistol()
        {
            GameObject Temporary_Bullet_Handler;
            Rigidbody Temporary_RigidBody;

            Temporary_Bullet_Handler = Instantiate(Bullet, ShootPlace.transform.position, ShootPlace.transform.rotation) as GameObject;

            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            Temporary_RigidBody.AddForce(transform.forward * Bullet_Force);

            audioSource.clip = puckPistolShot;

            Destroy(Temporary_Bullet_Handler, 4.0f);
        }

        // Update is called once per frame
        void Update()
        {
           

        }
    }
}

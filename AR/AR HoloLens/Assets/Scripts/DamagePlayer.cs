using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {

    public int playerHealth = 100;
    int damage = 25;

    public AudioSource audioSource;

    public AudioClip deathSound;
    public AudioClip hitSound;


    // Use this for initialization
    void Start ()
    {
        print(playerHealth);

        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = deathSound;
        audioSource.clip = hitSound;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            playerHealth -= damage;
            audioSource.Play();
            print("Ouch" + playerHealth);
        }

        if (playerHealth <= 0)
        {
            audioSource.Play();
            Application.LoadLevel("IceRink");
        }
    }

}

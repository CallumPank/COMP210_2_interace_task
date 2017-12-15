using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour {

    public EnemyMovement moveMotor;

    public int enemyHealth = 100;
    int damage = 25;

    // Use this for initialization
    void Start()
    {
        print(enemyHealth);
    }

    }



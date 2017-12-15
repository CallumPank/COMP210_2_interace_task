using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public DamageEnemy healthMotor;       // Players Health Script
    public GameObject Enemy;                // The Enemy Being Spawned
    public float spawningTime = 2f;            // How long before next enemy spawns
    public Transform[] spawnPoints;         // Array that enemies spawn from


    void Start()
    {
        //Reapts the spawning process of enemies
        InvokeRepeating("Spawn", spawningTime, spawningTime);
    }


    void Spawn()
    {
        //Enemies wont span if player health reaches zero
        if (healthMotor.enemyHealth <= 0f)
        {
            
            return;
        }

        //Picks somewhere inbetween the range of the array to spawn enemies
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        //Spawns enemies at the rotation and location of the spawn point 
        Instantiate(Enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
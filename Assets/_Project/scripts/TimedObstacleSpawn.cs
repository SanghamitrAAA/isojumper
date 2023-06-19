using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObstacleSpawn : MonoBehaviour
{
    // The axis and direction in which the obstacle needs to roll
    //[SerializeField] private Vector3 rollingDirection;

    // An object with a transform located at the one side of block. Obstacle is spawned on this location.
    [SerializeField] private Transform FirePlace;
    private bool _isMoving;
    public GameObject obstacle;
    public bool stopSpawning;
    public Rigidbody rb;
    public float spawnTime;
    public float spawnDelay;
    // float obstacleYSpeed, obstacleZSpeed;
    // public float obstacleSpeed;
    
    void Start()
    {
        _isMoving = true;
        rb = obstacle.GetComponent<Rigidbody>();
        // invove repeating call
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        //obstacleYSpeed = 1 * Time.fixedDeltaTime;
        //obstacleZSpeed = 1 * Time.fixedDeltaTime;
    }

    public void SpawnObject()
    {
        Instantiate(obstacle, FirePlace.position, FirePlace.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject"); 
        }
    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    
    //}
    
}

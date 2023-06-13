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
    public float ObstacleForce;
    //public float spawnTime;
    //public float spawnDelay;

    //float obstacleYSpeed, obstacleZSpeed;
    //public float obstacleSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //_isMoving = true;
        // invove repeating call
        //InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        //obstacleYSpeed = 1 * Time.fixedDeltaTime;
        //obstacleZSpeed = 1 * Time.fixedDeltaTime;
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }

    // Update is called once per frame
    public void SpawnObject()
    {
        Instantiate(obstacle, FirePlace.position, FirePlace.rotation);
        Rigidbody rb = obstacle.GetComponent<Rigidbody>();
        rb.AddForce(FirePlace.forward * ObstacleForce, ForceMode.Impulse);
        //transform.position = new Vector3(transform.position.y + obstacleYSpeed, transform.position.z + obstacleZSpeed);

        //if (stopSpawning)
        //{
        //    CancelInvoke("SpawnObject"); 
        //}
    }
    
}

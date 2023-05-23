using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookVector = target.position - transform.position;

        transform.rotation = Quaternion.LookRotation(lookVector);
    }


    // player rotation (will stand always on top of a surface - only activated when camera rotates)
    // For player: Quaternion.FromToRotation
}

// if all all top platforms are flipped -> rotate world 120* with X speed + rotating sound
// -> spawn character (on current block to top side of current block)

// LEVELS
// increase row +1 after every level level 1 = three blocks
// Speed of obstacles increase

// EXTRAS
// Create prefab for obstacle generating blocks that get placed randomly with X propability
// Prefab generates rolling obstacles with X Speed
// Speed 
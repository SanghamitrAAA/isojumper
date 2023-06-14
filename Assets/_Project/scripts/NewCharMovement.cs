using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NOTE: create multiple positions where spawner could appear and create a function that places them randomliy from list of positions
// NOT 2: Create one basic spawner for every side / direction
public class NewCharMovement : MonoBehaviour
{
    //[SerializeField] float moveSpeed = 4f;
    [SerializeField] float jumpForceConst = 5f;

    // CHECK FOR MID AIR JUMPS (only jump when feet are in radius of sphere)
    // CUBES IS SET TO LAYER "FloorLayer"
    [SerializeField] private Transform FeetTransform;
    [SerializeField] private LayerMask FloorMask;
    public float Speed;
    public Rigidbody rb;
    private Animator animator;

    //private bool isJumping = false;
    //public GameObject ground;
    // sees if it is on ground or not
    //float offset;
    //private bool isGrounded = true;

    //FOR SMOOTH CHAR ROTATION
    float rotateFloat;
    float Angle;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void JumpA()
    {     
        //if (Physics.CheckSphere(FeetTransform.position, 0.01f, FloorMask))
        //{
        //    //Check if characters feet (gameObject) are on cube - prevents MidAirJumps
        //    if (Input.GetKeyDown("space") && (!Input.GetKeyDown("a")))
        //    {
        //        animator.SetTrigger("Jump");
        //        Vector3 MoveVector = new Vector3(0, -3, -3) * Speed;
        //        //transform.position += MoveVector;
        //        rb.velocity += new Vector3(MoveVector.x, rb.velocity.y, MoveVector.z);
        //        rb.AddForce(Vector3.up * jumpForceConst, ForceMode.Impulse);
        //        TriggerLandingAnimation();
        //        Debug.Log("space for a");
        //    } 
        //}
    }

    void JumpD()
    {
        if (Input.GetKeyDown("space") && (!Input.GetKeyDown("d")))
        {
            transform.position += new Vector3(3, -3, 0);
            Debug.Log("space for d");
        }
    }

    void JumpE()
    {
        if (Input.GetKeyDown("space") && (!Input.GetKeyDown("e")))
        {
            transform.position += new Vector3(0,3,3);
            Debug.Log("space for e");
        }
    }


    void JumpW()
    {
        if (Input.GetKeyDown("space") && (!Input.GetKeyDown("w")))
        {
        transform.position += new Vector3(-3,3,0);
        Debug.Log("space for w");
        }
    }

    void FixedUpdate()
    {
        //A
        if (Input.GetKey("a"))
        {
            float Angle = 0;
            float Smooth = Mathf.SmoothDamp(transform.eulerAngles.y , Angle, ref rotateFloat, 0.05f);
            transform.rotation = Quaternion.Euler(0, Smooth, 0);
            Debug.Log("rotate for a");
            JumpA();
            //play jump sound
        }
        //W
        if (Input.GetKey("w"))
        {
            float Angle = 90;
            float Smooth = Mathf.SmoothDamp(transform.eulerAngles.y , Angle, ref rotateFloat, 0.1f);
            transform.rotation = Quaternion.Euler(0, Smooth, 0);
            Debug.Log("rotate for w");
            JumpW();
        }
        
        //D
        else if (Input.GetKey("d"))
        {
            float Angle = 270;
            float Smooth = Mathf.SmoothDamp(transform.eulerAngles.y , Angle, ref rotateFloat, 0.1f);
            transform.rotation = Quaternion.Euler(0, Smooth, 0);
            JumpD();
        }

        //E
        else if (Input.GetKey("e"))
        {
            float Angle = 180;
            float Smooth = Mathf.SmoothDamp(transform.eulerAngles.y , Angle, ref rotateFloat, 0.1f);
            transform.rotation = Quaternion.Euler(0, Smooth, 0);
            JumpE();
        }

    }

    //private void OnCollisionEnter(Collision other)
    //{
    //}


    void TriggerLandingAnimation()
    {
        animator.SetTrigger("Land");
        //play landing sound
    }
}
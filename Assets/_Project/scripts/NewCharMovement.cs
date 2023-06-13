using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NOTE: create multiple positions where spawner could appear and create a function that places them randomliy from list of positions
// NOT 2: Create one basic spawner for every side / direction
public class NewCharMovement : MonoBehaviour
{
    //[SerializeField] float moveSpeed = 4f;
    [SerializeField] float jumpForceConst = 20f;
    public Rigidbody rb;
    public Animator animator;
    // check if player is in mid jump to avoid double jumps in the air
    // -> check if character is jumping / check if character is standing on tile
    public string midJump = "n";
    //private bool isJumping = false;
    //public GameObject ground;
    // sees if it is on ground or not
    //float offset;
    //private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = gameObject.GetComponent<Animator>();
        //offset = (transform.position.y - ground.transform.position.y)+1;
    }

    void JumpA()
    {
        //midJump = "y";        
        if (Input.GetKeyDown("space") && (!Input.GetKeyDown("a")))
        {
            animator.SetBool("Jump", true);
            rb.AddForce(transform.up * jumpForceConst, ForceMode.Impulse);
            transform.position += new Vector3(0, -3, -3);
            TriggerLandingAnimation();
            Debug.Log("space for a");
        }
    }

    void JumpD()
    {
        midJump = "y";
        if (Input.GetKeyDown("space") && (!Input.GetKeyDown("d")) && (midJump=="n"))
        {
            transform.position += new Vector3(3, -3, 0);
            Debug.Log("space for d");
        }
    }

    void JumpE()
    {
        midJump = "y";
        if (Input.GetKeyDown("space") && (!Input.GetKeyDown("e")))
        {
            transform.position += new Vector3(0,3,3);
            Debug.Log("space for e");
        }
    }


    void JumpW()
    {
        midJump = "y";
        if (Input.GetKeyDown("space") && (!Input.GetKeyDown("w")) && (midJump=="n"))
        {
        transform.position += new Vector3(-3,3,0);
        Debug.Log("space for w");
        }
    }

    void Update()
    {
        //A
        if (Input.GetKey("a"))
        {
            transform.eulerAngles = new Vector3(0,0,0);
            Debug.Log("rotate for a");
            JumpA();
            //play jump sound
        }
        //W
        if (Input.GetKey("w"))
        {
            transform.eulerAngles = new Vector3(0,90,0);
            Debug.Log("rotate for w");
            JumpW();
        }
        
        //D
        if (Input.GetKey("d"))
        {
            transform.eulerAngles = new Vector3(0,-90,0);
            JumpD();
        }

        //E
        if (Input.GetKey("e"))
        {
            transform.eulerAngles = new Vector3(0,-180,0);
            JumpE();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        StartCoroutine(delayMove());
    }

    //Prevents midjump jumps / can only jump when landed
    IEnumerator delayMove()
    {
        yield return new WaitForSeconds(.05f);
        midJump = "n";
    }

    void TriggerLandingAnimation()
    {
        animator.SetBool("Jump", false);
        animator.SetTrigger("Land");
        //play landing sound
    }
}
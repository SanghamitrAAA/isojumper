using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NOTE: create multiple positions where spawner could appear and create a function that places them randomliy from list of positions
// NOT 2: Create one basic spawner for every side / direction
public class NewCharMovement : MonoBehaviour
{
    [SerializeField] float jumpForceConst = 20f;

    // CHECK FOR MID AIR JUMPS (only jump when feet are in radius of sphere)
    // CUBES IS SET TO LAYER "FloorLayer"
    [SerializeField] private Transform FeetTransform;
    [SerializeField] private LayerMask FloorMask;
    public float Speed;

    //Init Rigidbody and Animator
    public Rigidbody rb;
    private Animator animator;

    //JUMPING
    private Vector3 endPosition;
    private Vector3 startPosition;
    private float desiredDuration = 2f;
    private float elapsedTime;
    public string jumpState;

    //FOR SMOOTH CHAR ROTATION
    float rotateFloat;
    int Angle;

    float timer=0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * jumpForceConst, ForceMode.Impulse);
        animator = GetComponent<Animator>();
        animator.SetBool("Jump", false);
        startPosition = transform.position;
    }

    void TriggerLandingAnimation()
    {
        animator.SetBool("Jump", false);
        animator.SetTrigger("Land");
        //play landing sound
    }

    IEnumerator JumpCoroutine(Vector3 endPosition)
    {
        float jumpHeight = 2.0f; 
        float jumpDuration = 0.5f; 

        Vector3 startPosition = transform.position;
        Vector3 peakPosition = (startPosition + endPosition) * 0.5f;
        peakPosition.y += jumpHeight + 5f; //to control the curve

        float time = 0f;

        while (time < jumpDuration)
        {
            time += Time.deltaTime;

            float t = time / jumpDuration;

            //quadratic equation to create a parabolic trajectory
            Vector3 position = MathParabola(startPosition, peakPosition, endPosition, t);

            //update character's position
            transform.position = position;

            yield return null;
        }

        //character reaches the exact end position
        transform.position = endPosition;

        //play sounds
    }

    //quadratic equation to create a parabolic trajectory
    Vector3 MathParabola(Vector3 start, Vector3 peak, Vector3 end, float t)
    {
        float u = 1f - t;
        float tt = t * t;
        float uu = u * u;

        Vector3 position = (uu * start) + (2f * u * t * peak) + (tt * end);
        return position;
    }

    //OLD
    //void JumpA()
    //{
        //if (Physics.CheckSphere(FeetTransform.position, 0.01f, FloorMask))
        //{
        //}
    //}

    void Update()
    {
        elapsedTime += Time.deltaTime;
        // make rotation with lerp to make sure it's completely rotated
        float charRotationSpeed = 0.02f;
        //A
        if (Input.GetKey("a"))
        {
            int Angle = 0;
            float Smooth = Mathf.SmoothDamp(transform.eulerAngles.y , Angle, ref rotateFloat,charRotationSpeed);
            transform.rotation = Quaternion.Euler(0, Smooth, 0);
            Debug.Log("rotate for a");
            jumpState = "A";
            //play jump sound
        }
        //W
        if (Input.GetKey("w"))
        {
            int Angle = 90;
            float Smooth = Mathf.SmoothDamp(transform.eulerAngles.y , Angle, ref rotateFloat, charRotationSpeed);
            transform.rotation = Quaternion.Euler(0, Smooth, 0);
            Debug.Log("rotate for w");
            jumpState = "W";
        }
        
        //D
        if (Input.GetKey("d"))
        {
            int Angle = 270;
            float Smooth = Mathf.SmoothDamp(transform.eulerAngles.y , Angle, ref rotateFloat, charRotationSpeed);
            transform.rotation = Quaternion.Euler(0, Smooth, 0);
            Debug.Log("rotate for d");
            jumpState = "D";
        }

        //E
        if (Input.GetKey("e"))
        {
            int Angle = 180;
            float Smooth = Mathf.SmoothDamp(transform.eulerAngles.y , Angle, ref rotateFloat, charRotationSpeed);
            transform.rotation = Quaternion.Euler(0, Smooth, 0);
            Debug.Log("rotate for e");
            jumpState = "E";
        }

        if (Input.GetKeyDown("space"))
        {
            float percentageComplete = elapsedTime / desiredDuration;
            
            if (jumpState == "A")
            {   animator.SetBool("Jump", true);
                Vector3 jumpDirection = new Vector3(0, -3, -3);
                Vector3 endPosition = transform.position + jumpDirection;
                StartCoroutine(JumpCoroutine(endPosition));
                TriggerLandingAnimation();
                Debug.Log("space for a");
            }
            if (jumpState == "D")
            {
                animator.SetBool("Jump", true);
                Vector3 jumpDirection = new Vector3(3, -3, 0);
                Vector3 endPosition = transform.position + jumpDirection;
                StartCoroutine(JumpCoroutine(endPosition));
                TriggerLandingAnimation();
                Debug.Log("space for d");
            }
            if (jumpState == "E")
            {
                animator.SetBool("Jump", true);
                Vector3 jumpDirection = new Vector3(0, 3, 3);
                Vector3 endPosition = transform.position + jumpDirection;
                StartCoroutine(JumpCoroutine(endPosition));
                TriggerLandingAnimation();
                Debug.Log("space for e");
            }
            if (jumpState == "W")
            {
                animator.SetBool("Jump", true);
                Vector3 jumpDirection = new Vector3(-3, 3, 0);
                Vector3 endPosition = transform.position + jumpDirection;
                StartCoroutine(JumpCoroutine(endPosition));
                TriggerLandingAnimation();
                Debug.Log("space for w");
            }
        }
    }
}
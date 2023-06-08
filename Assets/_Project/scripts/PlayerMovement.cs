using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//public class PlayerMovement : MonoBehaviour
//{
//     [SerializeField] AudioClip _turnSound, _jumpSound, _landSound, _fallSound, _deathSound;
//    // variable to store character animator component
//    public Animator animator;
//    GameManager gameManager;
//    //Rigidbody _rigidbody;
//    //Vector3 _startPosition;
//    // variables to store optimized setter/getter parameter IDs
//    int isFacing;
//    int isJumping;
//    int isLanding;
//    // variable to store the instance of the PlayerInput
//    PlayerInput input;
//
//    // variables to store player input values
//    Vector3 currentFacing;
//    bool facingPressed;
//    bool jumpingPressed;
//    
//
//    void Awake()
//    {
//        input = new PlayerInput();
//
//        // access movemnt actions.
//        // current context: returns the current state of the callback, including the value of the input
//        input.CharacterControls.Jump.performed += ctx => ctx.ReadValueAsObject();
//        input.CharacterControls.FaceNorthEast.performed += ctx => ctx.ReadValueAsButton();
//        input.CharacterControls.FaceNorthWest.performed += ctx => ctx.ReadValueAsButton();
//        input.CharacterControls.FaceSouthEast.performed += ctx => ctx.ReadValueAsButton();
//        input.CharacterControls.FaceSouthWest.performed += ctx => ctx.ReadValueAsButton();
//
//    }
//
//    public static readonly Vector3 NoChange = Vector3.up;
//    public static readonly Vector3 NorthEast = Vector3.zero;
//    public static readonly Vector3 NorthWest = new Vector3(0, 270, 0);
//    public static readonly Vector3 SouthEast = new Vector3(0, 90, 0);
//    public static readonly Vector3 SouthWest = new Vector3(0, 100, 0);
//
//
//    // Start is called before the first frame update
//    void Start()
//    {
//        animator = GetComponent<Animator>();
//        isJumpingHash = Animator.StringToHash("Jump");
//        isLandinghash = Animator.StringToHash("Land");
//        //isFacingHash = Animator.StringToHash("Land");
//    }
//
//    // Update is called once per frame
//    void Update()
//    {
//        handleMovement();
//    }
//
//    void handleFacing()
//    {
//        landingPosition = _transform.position;
//        desiredFacing = NoChange;
//        //CREATE VARIABLES FOR EACH PLAYERINPUT
//        // grab current position of character as vector3
//        Vector3 currentPosition = transform.position;
//        // the change in position our character should point to
//        //Vector3 newPosition = new Vector3(currentPosition)
//
//        // up and right (NorthEast)
//        if (Input.facingPressed(FaceNorthEast))
//        {
//            desiredFacing = NorthEast;
//            landingPosition.y += 3;
//            landingPosition.z += 3;
//        }
//
//        // up and left (NorthWest)
//        if (Input.GetKey(KeyCode.Q))
//        {
//            desiredFacing = NorthWest;
//            landingPosition.y += 3;
//            landingPosition.x -= 3;
//        }
//
//        // Down and Right (SouthEast)
//        if (Input.GetKey(KeyCode.A))
//        {
//            desiredFacing = SouthEast;
//            landingPosition.y -= 3;
//            landingPosition.x += 3;
//        }
//
//        // Down and Left (SouthWest)
//        else if (Input.GetKey(KeyCode.D))
//        {
//            desiredFacing = SouthWest;
//            landingPosition.y -= 3;
//            landingPosition.z -= 3;
//        }
//    }
//
//    void handleMovement()
//    {
//        // get parameter values from animator
//        bool isJumping = animator.GetBool(isJumpingHash);
//        bool isLanding = animator.GetBool(isLandingHash);
//        //bool isFacing = animator.GetBool(isFacingHash);
//
//        // start changing facing if facingPressed is true and not already jumping
//        if (facingPressed && !isJumping)
//        {
//            //ChangeFacing(desiredFacing);
//            //rotate to desired facing direction
//        }
//
//        // start jumping if jumpingPressed is true 
//        if (jumpingPressed && isFacing)
//        {
//            animator.SetBool(isJumpingHash, true);
//            TriggerLandingAnimation();
//        }
//    }
//
//    //void ChangeFacing(Vector3 desiredFacing)
//    //{
//    //    if (desiredFacing == BoardManager.NoChange) return;
//    //    Body.DORotate(desiredFacing, 0.2f).SetAutoKill();      
//    //}
//
//    void TriggerLandingAnimation()
//    {
//        animator.SetBool(isJumpingHash, false);
//        animator.SetTrigger(isLandingHash);
//    }
//
//    void OnEnable()
//    {
//        // enable the character controls action map
//        input.CharacterControls.Enable();
//    }
//    void OnDisable()
//    {
//        // disable the character controls 
//        input.CharacterControls.Disable();
//    }
//
//    //void OnCollisionEnter(Collision other)
//    //{
//    //    if (!_jumping) return;
//    //    TriggerLandingAnimation();
//    //    //_animator.SetBool(JumpTrigger, false);
//    //    if (!CollidedWithPlatform(other, out var platform)) return;
//    //    _jumping = false;
//    //    if (!platform.Flipped)
//    //    {
//    //        platform.SetFlippedState(true);
//    //        return;
//    //    }
//    //    // play landing sound
//    //}
//
//    //bool CollidedWithPlatform(Collision other, out IPlatform platform)
//    //{
//    //    return other.collider.gameObject.TryGetComponent<IPlatform>(out platform);
//    //}
//
//    //public void ResetGecko(Vector3 geckoSpawnPosition, Vector3 geckoSpawnRotation)
//    //{
//    //    _jumping = _dead = false;
//    //    _animator.StartPlayback();
//    //    _startPosition = _transform.position = geckoSpawnPosition;
//    //    Body.eulerAngles = geckoSpawnRotation;
//    //    _rigidbody.velocity = _rigidbody.angularVelocity = Vector3.zero;
//    //    gameObject.SetActive(true);
//    //}
//}
//
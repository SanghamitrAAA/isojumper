using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class Gecko_Script : MonoBehaviour
{
    public Animator _animator;
    [SerializeField] AudioClip _turnSound, _jumpSound, _landSound, _fallSound, _deathSound; 

    static readonly int JumpTrigger = Animator.StringToHash("Jump");
    static readonly int LandTrigger = Animator.StringToHash("Land");
    bool _jumping = false, _dead = false;
    Transform _transform;
    Rigidbody _rigidbody;
    Vector3 _startPosition;

    BoardManager BoardManager => GameManager.Instance.BoardManager;

    public Transform Body { get; private set; }

    void Awake()
    {
        _transform = transform;
        Body = _transform.GetChild(0);
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (!GameManager.Instance.IsPlaying || _dead || _jumping) return;
        if (!ReceivedPlayerInput(out var desiredFacing, out var landingPosition)) return;

        ChangeFacing(desiredFacing);

        if (BoardManager.LandingOutOfBounds(landingPosition))
        {
            JumpOffEdge(landingPosition);
            return;
        }

        PerformJump(landingPosition);
    }

    // other = collision (just renamed)
    void OnCollisionEnter(Collision other)
    {
        if (!_jumping) return;
        TriggerLandingAnimation();
        //_animator.SetBool(JumpTrigger, false);
        if (!CollidedWithPlatform(other, out var platform)) return;
        _jumping = false;
        if (!platform.Flipped)
        {
            platform.SetFlippedState(true);
            return;
        }
        // play landing sound
    }

    void TriggerLandingAnimation()
    {
        _animator.SetBool(JumpTrigger, false);
        _animator.SetTrigger(LandTrigger);
    }

    public void ResetGecko(Vector3 geckoSpawnPosition, Vector3 geckoSpawnRotation)
    {
        _jumping = _dead = false;
        _animator.StartPlayback();
        _startPosition = _transform.position = geckoSpawnPosition;
        Body.eulerAngles = geckoSpawnRotation;
        _rigidbody.velocity = _rigidbody.angularVelocity = Vector3.zero;
        gameObject.SetActive(true);
    }

    public bool ReceivedPlayerInput(out Vector3 desiredFacing, out Vector3 landingPosition)
    {
        landingPosition = _transform.position;
        desiredFacing = BoardManager.NoChange;

        // up and right (NorthEast)
        if (Input.GetKey(KeyCode.E))
        {
            desiredFacing = BoardManager.NorthEast;
            landingPosition.y += 3;
            landingPosition.z += 3;
        }

        // up and left (NorthWest)
        if (Input.GetKey(KeyCode.Q))
        {
            desiredFacing = BoardManager.NorthWest;
            landingPosition.y += 3;
            landingPosition.x -= 3;
        }

        // Down and Right (SouthEast)
        if (Input.GetKey(KeyCode.A))
        {
            desiredFacing = BoardManager.SouthEast;
            landingPosition.y -= 3;
            landingPosition.x += 3;
        }

        // Down and Left (SouthWest)
        else if (Input.GetKey(KeyCode.D))
        {
            desiredFacing = BoardManager.SouthWest;
            landingPosition.y -= 3;
            landingPosition.z -= 3;
        }

        return landingPosition != _transform.position;
    }

    void ChangeFacing(Vector3 desiredFacing)
    {
        if (desiredFacing == BoardManager.NoChange) return;
        Body.DORotate(desiredFacing, 0.2f).SetAutoKill();      
    }

    void JumpOffEdge(Vector3 landingPosition)
    {
        // stop music
        // play fall sound
        Vector3 fallPosition = landingPosition;
        fallPosition.y = -10;
        if (landingPosition.z > 20)
        {
            fallPosition.z = 30;
        }
        else if (landingPosition.z < 0)
        {
            fallPosition.z = -10;
        }
        else if (landingPosition.x < 0)
        {
            fallPosition.x = -10;
        }
        else if (landingPosition.x > 10)
        {
            fallPosition.x = 20;
        }
        else
        {
            if (Body.eulerAngles == BoardManager.SouthEast)
            {
                fallPosition.x += 10;
            }
            else
            {
                fallPosition.z -= 10;
            }

        }
        //fallPosition, jumpPower: 25, numJumps: 1, duration: 1
        _transform.DOJump(fallPosition, 25, 1, 1).SetEase(Ease.InSine).SetAutoKill();
        //_deathSound = true;
        //_deathSound.Play();
        GameManager.Instance.PlayerDied();
    }

    bool CollidedWithPlatform(Collision other, out IPlatform platform)
    {
        return other.collider.gameObject.TryGetComponent<IPlatform>(out platform);
    }

    void PerformJump(Vector3 landingPosition)
    {
        _jumping = true;
        _animator.SetBool(JumpTrigger, true);
        //play jump sound
        _transform.DOJump(landingPosition, 4, 1, 0.5f).SetEase(Ease.Linear).SetAutoKill();
    }

}

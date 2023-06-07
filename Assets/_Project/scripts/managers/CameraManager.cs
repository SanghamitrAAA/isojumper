using UnityEngine;
using UnityEngine.InputSystem;
using System;
using DG.Tweening;

public class CameraManager : MonoBehaviour
{
    //Timer _timer;
    ////private Vector2 _delta;
    //private float _xRotation;
    //private float _zRotation;
    //private float _rotationTimer = 5f; // Timer for rotation in seconds
    //private bool _isRotating = false;

    //public Vector3 CamVector transform.forward;

    //CamVector = _transform.forward;

    //[SerializeField] private float rotationSpeed = 0.5f;

    //void Start()
    //{
    //    this.transform.LookAt(new Vector3(0f,0f,0f));
    //}

    //private void Awake()
    //{
    //    _xRotation = transform.rotation.eulerAngles.x;
    //    _zRotation = transform.rotation.eulerAngles.z;
    //}

    //public void RotateCubes()
    //{
    //    this.transform.Rotate(new Vector3(0f, 0f, 120f));
    //    var currentX = Mathf.Ceil(transform.rotation.eulerAngles.x);
    //    var currentY = Mathf.Ceil(transform.rotation.eulerAngles.y)
    //    remainingTime = GetComponent<Timer>();
    //    if (_timer.remainingDuration <= 1)
    //    {
    //        this.transform.Rotate(new Vector3(0f, 0f, 120f));
    //        //.SetEase(Ease.OutBounce);
    //    }
    //}

    //void Update()
    //{
    //    if (!_isRotating)
    //    {
    //        _rotationTimer -= Time.deltaTime;
//
    //        if (_rotationTimer <= 0f)
    //        {
    //            RotateCubes();
    //            _rotationTimer = 5f; // Reset the timer
    //        }
    //    }
    //}

    //private void SnapRotation()
    //{
    //    transform.DORotate(SnappedVector(), 0.5f)
    //    .SetEase(Ease.OutBounce);
    //}

    //private Vector3 SnappedVector()
    //{
    //    var endValue = 0.0f;
    //    var currentZ = Mathf.Ceil(transform.rotation.eulerAngles.z);
    //    var currentX = Mathf.Ceil(transform.rotation.eulerAngles.x);
    //    var currentY = Mathf.Ceil(transform.rotation.eulerAngles.y);
//
    //    endValue = currentZ switch
    //    {
    //        >= 0 and <= 120 => 120.0f,
    //        >= 121 and <= 240 => 240.0f,
    //        _ => 360.0f
    //    };
//
    //    return new Vector3(currentX, currentY, endValue);
    //}
}
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using DG.Tweening;

public class CameraManager : MonoBehaviour
{
    private Vector2 _delta;
    private bool _isMoving;
    private bool _isRotating;
    private float _xRotation;
    private float _zRotation;
    private bool _isBusy;

    //movement speed
    [SerializeField] private float movementSpeed = 10.0f;
    [SerializeField] private float rotationSpeed = 0.5f;

    private void Awake()
    {
        _xRotation = transform.rotation.eulerAngles.x;
        _zRotation = transform.rotation.eulerAngles.z;
    }
    public void OnLook(InputAction.CallbackContext context)
    {
        _delta = context.ReadValue<Vector2>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        //if (_isBusy) return;

        _isMoving = context.started || context.performed;

        //if (context.canceled)
        //{
        //    _isBusy = true;
        //    SnapRotation();
        //}
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        if (_isBusy) return;

        _isRotating = context.started || context.performed;

        if (context.canceled)
        {
            _isBusy = true;
            SnapRotation();
        }
    }

    private void LateUpdate()
    {
        var currentX = Mathf.Ceil(transform.rotation.eulerAngles.x);
        var currentY = Mathf.Ceil(transform.rotation.eulerAngles.y);
        if (_isMoving) 
        {
            var position = transform.right * (_delta.x * -movementSpeed);
            position += transform.up * (_delta.y * -movementSpeed);
            transform.position += position * Time.deltaTime;
        }

        if (_isRotating)
        {
            //transform.Rotate(new Vector3(currentX, currentY, _delta.x * rotationSpeed));
            transform.Rotate(new Vector3(_zRotation, 0.0f, _delta.x * rotationSpeed));

            //transform.rotation = Quaternion.Euler(_zRotation, 0.0f, transform.rotation.eulerAngles.z);

            //transform.Rotate(new Vector3(_xRotation, 0.0f, -_delta.x * rotationSpeed));
            //transform.rotation = Quaternion.Euler(_xRotation, 0.0f, transform.rotation.eulerAngles.y);

            //rotate around vector
            //transform.Rotate(Vector3.up, 90);
            //transform.Rotate(Vector3.z, 120);

            //transform.Rotate(new Vector3(_xRotation, -_delta.x * rotationSpeed, 0.0f));
            //transform.rotation = Quaternion.Euler(_xRotation, transform.rotation.eulerAngles.y, 0.0f);
        }
    }

    private void SnapRotation()
    {
        transform.DORotate(SnappedVector(), 0.5f)
        .SetEase(Ease.OutBounce)
        .OnComplete(() => 
        {
            _isBusy = false;
        });

    }

    private Vector3 SnappedVector()
    {
        var endValue = 0.0f;
        var currentZ = Mathf.Ceil(transform.rotation.eulerAngles.z);
        var currentX = Mathf.Ceil(transform.rotation.eulerAngles.x);
        var currentY = Mathf.Ceil(transform.rotation.eulerAngles.y);

        endValue = currentZ switch
        {
            >= 0 and <= 120 => 120.0f,
            >= 121 and <= 240 => 240.0f,
            _ => 360.0f
        };

        return new Vector3(currentX, currentY, endValue);
    }
}

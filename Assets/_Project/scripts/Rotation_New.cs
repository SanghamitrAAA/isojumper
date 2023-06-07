using UnityEngine;
using UnityEngine.InputSystem;
using System;
using DG.Tweening;

public class Rotation_New : MonoBehaviour
{
    Timer _timer;
    private float _xRotation;
    private float _zRotation;
    private float _rotationTimer = 5f; // Timer for rotation in seconds
    private bool _isRotating = false;

    //public Vector3 CamVector transform.forward;

    //CamVector = _transform.forward;

    //[SerializeField] private float rotationSpeed = 0.5f;

    void Start()
    {
        //this.transform.LookAt(new Vector3(0f,0f,0f));
    }

    public void RotateCubes()
    {
        //new Vector3(0f, 0f, 120f * 2f);
        transform.Rotate(new Vector3(0f, 0f, 120f));
        //transform.Rotate(new Vector3(0f, 0f, 120f) * Time.deltaTime)
        //this.transform.Rotate(new Vector3(0f, 0f, 120f));
    }

    void Update()
    {
        if (!_isRotating)
        {
            _rotationTimer -= Time.deltaTime;

            if (_rotationTimer <= 0f)
            {
                RotateCubes();
                _rotationTimer = 5f; // Reset the timer
            }
        }
    }
}
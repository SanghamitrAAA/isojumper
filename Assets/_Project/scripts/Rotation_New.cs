using UnityEngine;
using UnityEngine.InputSystem;
using System;
using Random=UnityEngine.Random;

public class Rotation_New : MonoBehaviour
{
    public Timer _timer;
    private float _xRotation;
    private float _zRotation;
    private float _rotationTimer = 5f; // Timer for rotation in seconds
    private bool _isRotating = false;
    //[SerializeField] float lerpTime = 5f;
    //[SerializeField] Vector3[] myAngles;
    //int angleIndex;
    //int len;
    //float t = 0f;

    //NEW
    public Quaternion targetRotation;
    float smooth = 5.0f;

    void Start()
    {
        //len = myAngles.Length;
        targetRotation = transform.rotation;
    }


    void Update()
    {
        if (!_isRotating)
        {
            _rotationTimer -= Time.deltaTime;

            if (_rotationTimer <= 0f)
            {
                targetRotation = Quaternion.AngleAxis(120.0f, transform.forward) * transform.rotation;
                //transform.rotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler (myAngles[angleIndex]), lerpTime*Time.deltaTime); //, Time.time * speed //lerpTime*Time.deltaTime
                //timeCount = timeCount + Time.deltaTime;
                _rotationTimer = 5f; // Reset the timer
                //angleIndex = Random.Range(0, len - 1);
            }
            transform.rotation = Quaternion.Slerp(transform.rotation,targetRotation, smooth * Time.deltaTime);
        }
    }
}
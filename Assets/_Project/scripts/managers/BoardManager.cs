using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    List<Transform> _platforms;
    Transform _transform;
    List<Vector3> _downDirections, _upDirections;

    //private float _rotationTimer = 5f; // Timer for rotation in seconds
    //private bool _isRotating = false;

    //private GameObject _allCubes;
    void Awake()
    {
        //_allCubes = getComponent
        _transform = transform;
        _downDirections = new List<Vector3>
        {
            new Vector3(3, -3, 0),
            new Vector3(0, -3, -3)
        };
        _upDirections = new List<Vector3>
        {
            new Vector3(-3, 3, 0),
            new Vector3(3, 3, 3)
        };
    }

    public int UnFlippedPlatforms => _platforms.Count(p => !p.GetComponent<IPlatform>().Flipped);



    void ResetPlatforms()
    {
        //platformsUp = Squares.GetComponeniInChildren<PlatformUp>();
        //platformsLeft = Squares.GetComponeniInChildren<PlatformLeft>();
        //platformsRight = Squares.GetComponeniInChildren<PlatformRight>();

        // Do this for every side
        if (UnFlippedPlatforms == _platforms.Count) return;

        foreach (var platform in _platforms)
        {
            var platformComponent = platform.GetComponent<IPlatform>();
            if (platformComponent.Flipped)
            {
                platformComponent.SetFlippedState(false);
            }
        }
    }

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

    //void RotateCubes()
    //{
    //    _isRotating = true;
        //_allCubes.transform.Rotate();

        // Vector to rotate camera around instead of Y

        //Vector3 WOW = _cameraManager.CamVector.transform.forward;

        //Vector3 cubeToCameraVector = _transform.forward;
        //Vector3 v = Quaternion.Euler(0f, 0f, 120f) * WOW;

        //Vector3 centerPosition = CalculateCenterPosition();
        //_transform.position = centerPosition;
//
        //Quaternion startRotation = _transform.rotation;
        //Quaternion targetRotation = Quaternion.Euler(_transform.eulerAngles + new Vector3(0f,120f,0f));
//
        //float duration = 1.0f; // Duration of the rotation in seconds
        //float elapsedTime = 0f;
//
        //while (elapsedTime < duration)
        //{
        //    _transform.rotation = Quaternion.Lerp(startRotation, targetRotation, elapsedTime / duration);
        //    elapsedTime += Time.deltaTime;
        //}
//
        //_transform.rotation = targetRotation;
        //_transform.position = Vector3.zero;
        //_isRotating = false;
    //}

    //Vector3 CalculateCenterPosition()
    //{
    //    Vector3 centerPosition = Vector3.zero;
//
    //    foreach (var platform in _platforms)
    //    {
    //        centerPosition += platform.position;
    //    }
//
    //    centerPosition /= _platforms.Count;
//
    //    return centerPosition;
    //}

    public bool LandingOutOfBounds(Vector3 landingPosition)
    {
        return landingPosition.z is > 20 or < 0 || landingPosition.x is < 0 or > 18 || landingPosition.y < 2.5f;
    }
}
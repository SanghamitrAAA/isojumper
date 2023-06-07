using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    [SerializeField] private Camera cameraRef;
    [SerializeField] private Color[] colors;
    //[SerializeFiled] private Color1 colorUp;
    //[SerializeFiled] private Color2 colorLeft;
    //[SerializeFiled] private Color3 colorRight;
    [SerializeField] private float colorChangeSpeed = 3.0F;
    [SerializeField] private float time;
    private float currentTime;
    private int colorIndex;

    private void Awake()
    {
        cameraRef = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        ColorChange();
        ColorChangeTime();
    }

    private void ColorChange()
    {
        cameraRef.backgroundColor = Color.Lerp(cameraRef.backgroundColor, colors[colorIndex], colorChangeSpeed * Time.deltaTime);
    }

    private void ColorChangeTime()
    {
        if (currentTime <= 0)
        {
            colorIndex++;
            currentTime = time;
            CheckColorIndex();
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndex()
    {
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }
    private void OnDestroy()
    {
        cameraRef.backgroundColor = colors[0];
    }
}

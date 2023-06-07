using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image uiTimer;
    [SerializeField] private Text uiCountdown;

    public int Duration;
    public int remainingDuration;
    private float fillAmountPerSecond;


    private void Start()
    {
        Begin(Duration);
    }

    private void Begin(int seconds)
    {
        remainingDuration = seconds;
        fillAmountPerSecond = 1f / seconds;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while (remainingDuration >= 0)
        {
            uiCountdown.text = remainingDuration.ToString();
            float fillAmount = remainingDuration * fillAmountPerSecond;
            uiTimer.fillAmount = fillAmount;
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        }
        //if (remainingDuration <= 1)
        //{
        //    checkpoint = GetComponent<onRotate>();
        //    CameraManager.RotateCamera.
        //}
    }  
}
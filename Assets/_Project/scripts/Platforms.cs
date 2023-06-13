using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//[System.Serializable]
public class Platforms : MonoBehaviour
{
    public Material _platformNormal; 
    public Material _platformFlipped;
    public Renderer _platformRenderer;
    public AudioClip _flipSound;

    public int colorStatus = 1;

   
    // Update is called once per frame
    void Update()
    {
        //SetPlatformColor();
        //SetFlippedState();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            colorStatus -=1;
            if (colorStatus == 0)
            {
                GetComponent<Renderer>().material = _platformFlipped;
                GameManager.remainingTiles -= 1;
            }

            //set colorstatus back to zero, so code above doesn't get executed
            if (colorStatus<0)
            {
                colorStatus = 0;
            }
        }

        if(other.gameObject.tag == "Obstacle")
        {
            colorStatus += 1;
            if (colorStatus == 1)
            {
                GetComponent<MeshRenderer>().material = _platformNormal;
                GameManager.remainingTiles += 1;
            }
            if (colorStatus >  1)
            {
                colorStatus = 1;
            }
        }
    }
}

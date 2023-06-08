using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Platforms : MonoBehaviour
{
    [SerializeField] Material _platformNormal; 
    [SerializeField] Material _platformFlipped;
    [SerializeField] Renderer _platformRenderer;
    [SerializeField] AudioClip _flipSound;

    public bool Flipped { get; private set; }

    public void SetFlippedState(bool flipped)
    {
        //Flipped = flipped;
        SetPlatformMaterial();
        if (flipped)
        {
            // play audio
            // add points to score
        }
        // tell game manager we flipped the platform
    }
    
    public void SetPlatformColor(Color color)
    {
        _platformRenderer.material.color = color;
    }    

    void SetPlatformMaterial()
    {
        _platformRenderer.material = Flipped ? _platformFlipped : _platformNormal;
    }
   
    // Update is called once per frame
    void Update()
    {
        //SetPlatformColor();
        //SetFlippedState();
    }
}

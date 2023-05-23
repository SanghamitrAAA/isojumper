using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_quad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newrotation = new Vector3(90, 10, 0);
        transform.eulerAngles = newrotation;        
    
    }

}    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Another simple script from Rollaball that rotates the powerup


public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime); 
    }
}

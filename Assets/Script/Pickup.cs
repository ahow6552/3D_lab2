using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    
    public float rotateAngle=45f;

    void Update () {
        transform.Rotate(new Vector3(0,0,rotateAngle*Time.deltaTime));
    } 
}

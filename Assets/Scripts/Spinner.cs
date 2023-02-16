using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float XRotation = 0f;
    [SerializeField] float YRotation = 0f;
    [SerializeField] float ZRotation = 0f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(XRotation, YRotation, ZRotation); 
    }
}

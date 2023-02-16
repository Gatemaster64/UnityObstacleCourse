using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Variables for the MeshRenderer and the RigidBody.
    MeshRenderer mrenderer;
    Rigidbody rbody;
    [SerializeField] float TimeToWait = 3f;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        // If statement for enabling the MeshRenderer and activating the gravity on the rigidbody once TimeToWait is over.
        if (Time.time > TimeToWait)
        {
            mrenderer = GetComponent<MeshRenderer>();
            mrenderer.enabled = true;

            rbody = GetComponent<Rigidbody>();
            rbody.useGravity = true;
        }
    }
}

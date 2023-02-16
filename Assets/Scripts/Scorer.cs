using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        // If statement for changing the score counter when the player collides with a Gameobject without the tag "Hit".
        if(other.gameObject.tag != "Hit")
        {  
            hits++;
            Debug.Log("you've bumpped into a thing this many times: " + hits);
        }
    }
}
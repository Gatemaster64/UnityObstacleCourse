using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        //Call the PrintInstructions Method
        PrintInstructions();  
    }

    // Update is called once per frame
    void Update()
    {
        // Call the Player movement method.
        MovePlayer(); 
    }


    // Declare method for PrintInstructions and for player movement.
    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("Move the player with wasd keys or arrow keys");
    }

    void MovePlayer()
    {
        // Variables to get player input.
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}

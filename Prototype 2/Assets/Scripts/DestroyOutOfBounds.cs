using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the player view in the game, remove that object
        if (transform.position.z > topBound) // If the position of pizza in the z axis goes beyond the topbound of 30 z
        {
            Destroy(gameObject); // Destroy the (pizza) gameObject itself on the top bound z (positive)
        }
        else if (transform.position.z < lowerBound) // Otherwise if it goes on the beyond the lowerBound of -10 z
        {
            Debug.Log("Game Over!"); // Print a "Game Over!" message in the Debug Log
            Destroy(gameObject); // Destroy the (animals) gameObject itself on the lower bound z (negative) instead
        }
    }
}

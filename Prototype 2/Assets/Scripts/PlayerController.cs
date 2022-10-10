using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput; // Input Movement of the player is in Horizontal
    private float speed = 15.0f;  // speed of the player's movement
    private float xRange = 20.0f; // xRange - the set right boundary which the player cannot access (e.g. 20 or 20.0f)| -xRange is left boundary (e.g. -20 or -20.0f)

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)  // If player x position is less than -20 (left)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); // Transform, stay and keep the player position in the left boundary at -20 and its current y and z transform positions 
        }

        if (transform.position.x > xRange)  // If player x position is greater than 20 (right)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); // Transform, stay and keep the player position in the right boundary at 20 and its current y and z transform positions 
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))  // If Space key is pressed down
        {
          // Launch a projectile from the player
          Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); // Launch the prefab projectile from the player's (set as Vector3) current position and/with the prefab's rotation

        }
    }
}

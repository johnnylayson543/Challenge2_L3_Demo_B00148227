using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float delayInput; // The variable/time in which the player is allowed to spawn the dog again

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && delayInput <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            delayInput = 1; // Set the delayInput to a specified amount of time to delay Input. In this case it is set to 1 by default.
        }
        // Use Time.deltaTime to remove delayInput value and reset it back to 0 (as it updates based on times per second) to allow Input again (decrease delay value of the Input over time)
        delayInput -= Time.deltaTime; 
    }
}

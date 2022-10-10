using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Override the Start() and Update() methods using a private function OnTriggerEnter with a Collider (for the Box Collider + on trigger) from the MonoBehaviour class
    private void OnTriggerEnter(Collider other)  // If the gameObject and/or the other gameObject collide each other with Box Collision + trigger
    {
        Destroy(gameObject); // Destroy the gameObject
        Destroy(other.gameObject); // Destroy the other gameObject
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;  // Create an GameObject array of animal prefabs (default is 3 animals as of current) for random spawn
    private float spawnRangeX = 20;  // Random range spawn position of GameObject array spawn from the x axis (can be called spawnRangePosX as well)
    private float spawnPosZ = 20;    // Spawn position of GameObject array spawn from the z axis

    private float startDelay = 2; // The delay before the start of the random animal spawn
    private float spawnInterval = 1.5f; // The time before the animals start spawning again
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); // Invoke and call a repeating function method that randomly spawns animals (2 secs delay start with 1.5f respawn intervals)
    }

    // Update is called once per frame
    void Update()
    {
        
        //if (Input.GetKeyDown(KeyCode.S))  // If S key is pressed down
        //{
        //  SpawnRandomAnimal();  // Call a function method that randomly spawns animals
        //}
        
    }

    void SpawnRandomAnimal()
    {
        //Randomly generate animal index (for the animalPrefabs array) and spawn position
        // The number index for the array where the/a animal is located
        // Set the animal index number for the animalPrefabs array based on the random range length of the animalPrefabs array (starts from element/index number 0 with an length ending of 3, the animalPrefabs exclusive number length)
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        
        // A new Vector3 to create a 3D coordinate for animal's spawn position (Based on a random range position of -20 to 20 for the x axis and just 20 for the z axis)
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); 

        // Spawn random animals from a new Vector3 (via set z coordinates) position and/with the animal prefab's array rotation
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

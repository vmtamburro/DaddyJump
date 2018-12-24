using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    //Generate the Entire Level at one time. Generate the Level as the player is moving through it. Loading level as player is playing it
    //so you don't have to store a giant level. Randomness to generate a level

    public GameObject platformPrefab;

    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;


	// Use this for initialization
	void Start () {
        Vector3 spawnPosition = new Vector3();

        for(int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
		
	}
	
}

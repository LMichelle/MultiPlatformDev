using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {
    public GameObject normalPlatformPrefab;
    public GameObject breakPlatformPrefab;

    public int amountOfPlatforms = 100;
    public float levelWidth = 4f;
    public float yHeight = 3f;

	// Use this for initialization
	void Start () {
        Vector3 spawnPos = new Vector3();
        for (int i = 0; i < amountOfPlatforms; i++) {
            spawnPos.y += yHeight;
            // x is iig nu een integer maar moet eigenlijk alleen dividable zijn door 2
            spawnPos.x = (int)Random.Range(-levelWidth, levelWidth);
            Instantiate(normalPlatformPrefab, spawnPos, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

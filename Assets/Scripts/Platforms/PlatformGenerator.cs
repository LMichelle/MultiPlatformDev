using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {
    public GameObject normalPlatformPrefab;
    public GameObject breakPlatformPrefab;
    private GameObject lastSpawnedPrefab;

    public int amountOfPlatforms = 100;
    public float levelWidth = 6f;
    public float yHeight = 3f;

	void Start () {
        GenerateLevel();
	}

    public void GenerateLevel() {
        Vector3 spawnPos = new Vector3(0f, -4.5f);
        for (int i = 0; i < amountOfPlatforms; i++) {
            spawnPos.y += yHeight;
            if (i % 2 != 0) {
                for (int x = -4; x < levelWidth; x += 4) {
                    spawnPos.x = x;
                    GameObject platform = ChoosePlatform();
                    GameObject finalPlat = Instantiate(platform, spawnPos, Quaternion.identity) as GameObject;
                    finalPlat.transform.parent = this.transform;
                }
            } else {
                for (int x = -6; x <= levelWidth; x += 4) {
                    spawnPos.x = x;
                    GameObject platform = ChoosePlatform();
                    GameObject finalPlat = Instantiate(platform, spawnPos, Quaternion.identity) as GameObject;
                    finalPlat.transform.parent = this.transform;
                }
            }
        }
    }
	
    public void SetLevelWidth(float width) {
        levelWidth = width;
    }

    public GameObject ChoosePlatform() {
        GameObject chosenPlatform;
        
        float value = Random.Range(0f, 1f);
        if (value <= 0.6f) {
            chosenPlatform = normalPlatformPrefab;
        } else {
            chosenPlatform = breakPlatformPrefab;
        }
        if (chosenPlatform == lastSpawnedPrefab) {
            chosenPlatform = normalPlatformPrefab;
        }
        lastSpawnedPrefab = chosenPlatform;
        return chosenPlatform;
    }
}

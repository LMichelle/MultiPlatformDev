using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartGenerator : MonoBehaviour {
    public GameObject heartPrefab;

    public int amountOfHearts = 90;
    public float levelWidth = 6f;
    public float yHeight = 3f;
    public bool spawn = false;

    // Use this for initialization
    void Start () {
        GenerateHearts();
	}
	
	public void GenerateHearts() {
        Vector3 spawnPos = new Vector3(0f, -3.5f);
        for (int i = 0; i < amountOfHearts; i++) {
            spawnPos.y += yHeight;
            if (i % 2 != 0) {
                for (int x = -4; x < levelWidth; x += 4) {
                    bool yes = SpawnOrNot();
                    if (yes) {
                        spawnPos.x = x;
                        GameObject hearts = Instantiate(heartPrefab, spawnPos, Quaternion.identity) as GameObject;
                        hearts.transform.parent = this.transform;
                    }
                    
                }
            } else {
                for (int x = -6; x <= levelWidth; x += 4) {
                    bool yes = SpawnOrNot();
                    if (yes) {
                        spawnPos.x = x;
                        GameObject hearts = Instantiate(heartPrefab, spawnPos, Quaternion.identity) as GameObject;
                        hearts.transform.parent = this.transform;
                    }  
                }
            }
        }
    }

    public bool SpawnOrNot() {
        return (Random.value > 0.5f);
    }
}

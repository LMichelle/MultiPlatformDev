using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {
    ScoreManager scoreManager;
    public int score;
    public bool destroyable;

    TimeManager timeManager;
    public int plusTime;

    private void Start() {
        scoreManager = ScoreManager.instance;
        timeManager = TimeManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        scoreManager.AddToScore(score);
        if (plusTime != 0) {
            timeManager.AddTime(plusTime);
        }
        if (destroyable) {
            Destroy(gameObject);
        }
        
    }
}

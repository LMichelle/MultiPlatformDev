using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    #region Singleton
    public static ScoreManager instance;

    private void Awake() {
        if (instance != null) {
            return;
        }
        instance = this;
    }
    #endregion


    public Text scoreText;
    public int score = 0;


    public void AddToScore(int num) {
        score += num;
        UpdateScore();
    }

    public void UpdateScore() {
        scoreText.text = score.ToString();
    }

    public void ResetScore() {
        score = 0;
    }
	
}

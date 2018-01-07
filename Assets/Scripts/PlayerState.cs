using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {
    UIManager uiManager;

	// Use this for initialization
	void Start () {
        uiManager = UIManager.instance;
        uiManager.onGameOverCallback += GameOverState;
	}
	
	public void GameOverState() {
        Collider2D col = this.GetComponent<Collider2D>();
        col.enabled = false;
    }
}

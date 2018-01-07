using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    #region Singleton
    public static UIManager instance;

    private void Awake() {
        if (instance != null) {
            return;
        }
        instance = this;
    }
    #endregion

    // delegates
    public delegate void OnGameOver();
    public OnGameOver onGameOverCallback;

    // Panels
    public GameObject GameOverPanel;


    // Use this for initialization
    void Start () {
        onGameOverCallback += ShowGameOverUI;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowGameOverUI() {
        GameOverPanel.SetActive(true);
    }
}

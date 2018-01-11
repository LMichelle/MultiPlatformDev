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
    public delegate void OnGameState();
    public OnGameState onGameOverCallback;
    public OnGameState onWinCallback;

    // Panels
    public GameObject GameOverPanel;
    public GameObject winPanel;


    void Start () {
        onGameOverCallback += ShowGameOverUI;
        onWinCallback += ShowWinUI;

	}
	
	public void ShowWinUI() {
        winPanel.SetActive(true);
    }

    public void ShowGameOverUI() {
        GameOverPanel.SetActive(true);
    }
}
